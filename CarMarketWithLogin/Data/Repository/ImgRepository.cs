using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Data.Repository
{
    public class ImgRepository : IImgs
    {
        private readonly ApplicationDbContext _appDbContent;

        public ImgRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<Img> Imgs => _appDbContent.Imgs;
    }
}