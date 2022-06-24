using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> Users { get; }
        User GetUser(string idUser);
    }
}