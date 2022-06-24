using System.Collections.Generic;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data.Repository
{
    public class CommentRepository : IComments
    {
        private readonly ApplicationDbContext _appDbContent;

        public CommentRepository(ApplicationDbContext appDbContent)
        {
            this._appDbContent = appDbContent;
        }

        public IEnumerable<Comment> Comments => _appDbContent.Comments
            .Include(x => x.Car)
            .Include(x => x.Content)
            .Include(x => x.User)
            .Include(x => x.Data)
            .Include(x => x.Tenure)
            .ToList();
    }
}