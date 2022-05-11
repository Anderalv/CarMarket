using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data.Repository
{
    public class EngineTypeRepository : IEngineType
    {
        private readonly ApplicationDbContext _appDbContent;

        public EngineTypeRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<EngineType> EngineTypes => _appDbContent.EngineTypes.Include(x => x.Cars).ThenInclude(x => x.Imgs);
    }
}