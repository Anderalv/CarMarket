using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IBodyType
    {
        IEnumerable<BodyType> BodyTypes { get; }
    }
}