using System.Collections.Generic;
using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Entities.Concrete;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreUserDal : EfCoreEntityRepositoryBase<User, EfCoreDatabaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new EfCoreDatabaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };

                return result.ToList();
            }
        }
    }
}