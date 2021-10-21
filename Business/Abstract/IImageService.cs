using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IImageService
    {
        IResult Add(Image image);
        IResult Update(Image image);
        IResult Delete(Image image);

        IDataResult<Image> GetById(int imageId);
        IDataResult<List<Image>> GetAll();
    }
}
