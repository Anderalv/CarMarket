using System.Linq;
using System.Security.Claims;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Helpers
{
    public static class UserExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal user) => user.Claims.First(x => x.Type == ClaimTypes.Email).Value.Equals("admin@admin.a");
        
    }
}