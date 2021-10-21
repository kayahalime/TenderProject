using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITenderService
    {
        IResult Add(Tender tender);
        IResult Update(Tender tender);
        IResult Delete(Tender tender);

        IDataResult<Tender> GetById(int tenderId);
        IDataResult<List<Tender>> GetAll();


    }
}
