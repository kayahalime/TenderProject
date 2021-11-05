
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TenderContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new TenderContext())
            {
                var result = from operationClaim in context.operationClaims
                             join userOperationClaim in context.userOperationClaims
                                 on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, OperationClaimName = operationClaim.OperationClaimName };
                return result.ToList();

            }
        }
    }
}