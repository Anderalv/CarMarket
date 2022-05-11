using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Data.Repository
{
    public class DriveUnitRepository : IDriveUnit
    {
        private readonly ApplicationDbContext _appDbContent;

        public DriveUnitRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<DriveUnit> DriveUnits => _appDbContent.DriveUnits;
    }
}