using System.Diagnostics;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CarMarketWithLogin.Models;
using X.PagedList;


namespace CarMarketWithLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _allCars;
        
        public HomeController(IAllCars allCars)
        {
            _allCars = allCars;
        }
        
        public IActionResult Index(int? page)
        {
            const int pageSize = 3;
            var pageNumber = page ?? 1;
            return View(_allCars.Cars.OrderBy(x => x.Brand).ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [Route("/Home/SortPrice")]
        public ViewResult SortPrice()
        {
            return View(_allCars.Cars.OrderBy(x => x.RecommendPrice));
        }
        
        [Route("/Home/SortYear")]
        public ViewResult SortYear()
        {
            
            return View(_allCars.Cars.OrderBy(x => x.StartYear));
            
        }
    }
}