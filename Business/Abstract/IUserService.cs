using System;
using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetByMail(string email);
        IResult ProfileUpdate(User user, string password);
        IDataResult<List<User>> GetAll();
        IResult UserUpdateExists(string email, int id);
    }
}
