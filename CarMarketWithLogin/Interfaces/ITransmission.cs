using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface ITransmission
    {
        IEnumerable<Transmission> Transmissions { get; }
    }
}