using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CarMarketWithLogin.Models
{
    public class User : IdentityUser
    {
        public List<Comment> Comments { get; set; }
        public List<BookMark> BookMarks { get; set; }
    }
}