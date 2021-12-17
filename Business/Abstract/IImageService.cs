using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> Get(int id);
        IResult Add(IFormFile file, Image image);
        IResult Update(IFormFile file, Image image);
        IResult Delete(Image image);
        IDataResult<List<Image>> GetImagesByTenderId(int id);
    }
}
