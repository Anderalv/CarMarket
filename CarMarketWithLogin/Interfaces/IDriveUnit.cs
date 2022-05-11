using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IDriveUnit
    {
        IEnumerable<DriveUnit> DriveUnits { get; }
    }
}