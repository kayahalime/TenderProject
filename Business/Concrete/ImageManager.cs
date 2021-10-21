using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ImageManager:IImageService
    {
        IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }


        public IResult Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Image image)
        {
            _imageDal.Delete(image);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Image> GetById(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.ImageId == imageId));
        }

        public IResult Update(Image image)
        {
            _imageDal.Update(image);
            return new SuccessResult(Messages.Updated);
        }
    }
}
