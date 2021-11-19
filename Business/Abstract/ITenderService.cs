using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ITenderService
    {
        IResult Add(Tender tender);
        IResult Update(Tender tender);
        IResult Delete(Tender tender);
        IDataResult<List<Tender>> GetTendersByCategoryId(int categoryId);
        IDataResult<List<TenderDetailDto>> GetTenderDetails();
        IDataResult<List<TenderDetailDto>> GetByFilter(int categoryId);
        IDataResult<Tender> GetById(int tenderId);
        IDataResult<List<Tender>> GetAll();


    }
}
