using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITenderDal : IEntityRepository<Tender>
    {

        List<TenderDetailDto> GetByFilter(int categoryId);
        List<TenderDetailDto> GetTenderDetails();
    }
}
