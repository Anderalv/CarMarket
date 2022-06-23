using System.Collections.Generic;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data.Repository
{
    public class BookMarkRepository : IBookMarks
    {
        private readonly ApplicationDbContext _appDbContent;

        public BookMarkRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        public IEnumerable<BookMark> BookMarks => _appDbContent.BookMarks
            .Include(x => x.Car)
            .Include(x=>x.User);
    }
}