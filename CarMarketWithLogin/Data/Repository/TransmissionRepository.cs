using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Data.Repository
{
    public class TransmissionRepository : ITransmission
    {
        private readonly ApplicationDbContext _appDbContent;

        public TransmissionRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<Transmission> Transmissions => _appDbContent.Transmissions;
    }
}