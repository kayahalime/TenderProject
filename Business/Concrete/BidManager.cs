using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BidManager: IBidService
    {
        IBidDal _bidDal;
        public BidManager(IBidDal bidDal)
        {
            _bidDal = bidDal;
        }


        public IResult Add(Bid bid)
        {
            _bidDal.Add(bid);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Bid bid)
        {
            _bidDal.Delete(bid);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Bid>> GetAll()
        {
            return new SuccessDataResult<List<Bid>>(_bidDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Bid> GetById(int bidId)
        {
            return new SuccessDataResult<Bid>(_bidDal.Get(b => b.BidId == bidId));
        }

        public IResult Update(Bid bid)
        {
            _bidDal.Update(bid);
            return new SuccessResult(Messages.Updated);
        }
    }
}
