using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IImgs
    {
        IEnumerable<Img> Imgs { get; }
    }
}