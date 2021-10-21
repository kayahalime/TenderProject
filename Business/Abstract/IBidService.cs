using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBidService
    {
        IResult Add(Bid bid);
        IResult Update(Bid bid);
        IResult Delete(Bid bid);

        IDataResult <Bid> GetById(int bidId);
        IDataResult<List<Bid>> GetAll();
    }
}
