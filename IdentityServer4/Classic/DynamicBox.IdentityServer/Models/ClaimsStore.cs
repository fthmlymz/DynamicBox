using System.Collections.Generic;
using System.Security.Claims;

namespace DynamicBox.IdentityServer.Models
{
    public class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("ReadRole", "ReadRole"),
            new Claim("CreateRole", "CreateRole"),
            new Claim("EditRole","EditRole"),
            new Claim("DeleteRole","DeleteRole")
        };
    }
}
