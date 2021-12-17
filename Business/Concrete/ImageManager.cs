using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }
        // [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, Image image)
        {
            var result = BusinessRules.Run(CheckTenderImageLimit(image));

            if (result != null)
            {
                return result;
            }

            image.ImagePath = FileHelper.AddAsync(file);
           
            _imageDal.Add(image);

            return new SuccessResult(Messages.Added);
        }
        //[ValidationAspect(typeof())]
        public IResult Delete(Image image)
        {
            IResult result = BusinessRules.Run(CheckTenderImageLimit(image));
            if (result != null)
            {
                return result;
            }

            _imageDal.Delete(image);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<Image> Get(int id)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(p => p.ImageId == id));
        }
        public IDataResult<List<Image>> GetAll()
        {

            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }


        public IDataResult<List<Image>> GetImagesByTenderId(int id)
        {
            return new SuccessDataResult<List<Image>>(CheckIfTenderImageNull(id));
        }


      //  [ValidationAspect(typeof(ImageValidator))]
        public IResult Update(IFormFile file, Image image)
        {
            image.ImagePath = FileHelper.UpdateAsync(_imageDal.Get(p => p.ImageId == image.ImageId).ImagePath, file);
         
            _imageDal.Update(image);
            return new SuccessResult(Messages.Updated);
        }
        private List<Image> CheckIfTenderImageNull(int id)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Images\default.jpg");
            var result = _imageDal.GetAll(c => c.TenderId == id).Any();
            if (!result)
            {
                return new List<Image> { new Image { TenderId = id, ImagePath = path } };
            }
            return _imageDal.GetAll(p => p.TenderId == id);
        }

        private IResult TenderImageDelete(Image image)
        {
            try
            {
                File.Delete(image.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        private IResult CheckTenderImageLimit(Image carImage)
        {
            if (_imageDal.GetAll(c => c.TenderId == carImage.TenderId).Count >= 5)
            {
                return new ErrorResult(Messages.Added);
            }

            return new SuccessResult();
        }

    }
}
