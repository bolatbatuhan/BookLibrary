using CorePackages.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePackages.Utilities.Security.JWT;

public interface ITokenHelper
{
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
}
