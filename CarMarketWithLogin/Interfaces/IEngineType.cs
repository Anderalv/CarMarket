using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IEngineType
    {
        IEnumerable<EngineType> EngineTypes { get; }
    }
}