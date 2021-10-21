using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService
    {
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);

        IDataResult<Admin> GetById(int adminId);
        IDataResult<List<Admin>> GetAll();
    }
}
