using System.Collections.Generic;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Interfaces
{
    public interface IBookMarks
    {
        IEnumerable<BookMark> BookMarks { get; }
    }
}