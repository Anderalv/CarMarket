using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface ICapacity
    {
        IEnumerable<Capacity> Capacities { get; }
    }
}