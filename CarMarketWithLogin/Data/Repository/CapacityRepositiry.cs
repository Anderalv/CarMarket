using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Data.Repository
{
    public class CapacityRepositiry : ICapacity
    {
        private readonly ApplicationDbContext _appDbContent;

        public CapacityRepositiry(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<Capacity> Capacities => _appDbContent.Capacities;
    }
}