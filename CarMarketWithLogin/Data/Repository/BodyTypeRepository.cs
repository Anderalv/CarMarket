using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Data.Repository
{
    public class BodyTypeRepository : IBodyType
    {
        private readonly ApplicationDbContext _appDbContent;

        public BodyTypeRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<BodyType> BodyTypes => _appDbContent.BodyTypes;
    }
}