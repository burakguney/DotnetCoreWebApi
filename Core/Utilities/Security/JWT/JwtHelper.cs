using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaim)
        {
            throw new System.NotImplementedException();
        }
    }
}