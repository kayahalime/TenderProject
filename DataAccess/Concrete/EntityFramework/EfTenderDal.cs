using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTenderDal : EfEntityRepositoryBase<Tender, TenderContext>, ITenderDal
    {
        public List<TenderDetailDto> GetByFilter(int categoryId)
        {
            using (TenderContext context = new TenderContext())
            {
                var result = from t in context.tenders
                             join c in context.categories
                             on t.CategoryId equals c.CategoryId
                           
                             select new TenderDetailDto
                             {
                                 TenderId = t.TenderId,
                                 CategoryName = c.CategoryName,
                                 Price = t.Price,
                                 Active = t.Active,
                                 StartingDate = t.StartingDate,
                                 EndDate = t.EndDate,
                             };
                return result.ToList();

            }
        }
        public List<TenderDetailDto> GetTenderDetails()
        {
            using (TenderContext context = new TenderContext())
            {
                var result = from t in context.tenders
                             join c in context.categories
                             on t.CategoryId equals c.CategoryId
                            
                             select new TenderDetailDto
                             {
                                 TenderId = t.TenderId,
                                 CategoryName = c.CategoryName,
                                 Price = t.Price,
                                 Active = t.Active,
                                 StartingDate = t.StartingDate,
                                 EndDate = t.EndDate,
                                 
                             };
                return result.ToList();

            }
        }
    }
}
