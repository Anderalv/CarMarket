using System.Collections.Generic;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data.Repository
{
    public class UserRepository : IUsers
    {
        private readonly ApplicationDbContext _appDbContent;

        public UserRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<User> Users => _appDbContent.Users
            .Include(x => x.Comments)
            .ThenInclude(x => x.Car)
            .Include(x => x.BookMarks)
            .ToList();
        
        public User GetUser(string idUser) => Users.FirstOrDefault(x => x.Id.Equals(idUser));
    }
}