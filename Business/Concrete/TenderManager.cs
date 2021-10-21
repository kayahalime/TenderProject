using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TenderManager: ITenderService
    {
        ITenderDal _tenderDal;
        public TenderManager(ITenderDal tenderDal)
        {
            _tenderDal = tenderDal;
        }


        public IResult Add(Tender tender)
        {
            _tenderDal.Add(tender);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Tender tender)
        {
            _tenderDal.Delete(tender);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Tender>> GetAll()
        {
            return new SuccessDataResult<List<Tender>>(_tenderDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Tender> GetById(int tenderId)
        {
            return new SuccessDataResult<Tender>(_tenderDal.Get(t => t.TenderId == tenderId));
        }

        public IResult Update(Tender tender)
        {
            _tenderDal.Update(tender);
            return new SuccessResult(Messages.Updated);
        }
    }
}
