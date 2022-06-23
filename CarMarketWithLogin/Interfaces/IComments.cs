using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IComments
    {
        IEnumerable<Comment> Comments { get; }
    }
}