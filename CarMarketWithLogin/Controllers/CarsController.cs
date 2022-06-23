using System.Linq;
using System.Threading.Tasks;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarsController : Controller
    {
        private readonly IEngineType _engineType;
        private readonly IAllCars _allCars;
        private readonly UserManager<User> _userManager;
        public CarsController(IEngineType iEngineType, IAllCars iAllCars, UserManager<User> userManager)
        {
            _engineType = iEngineType;
            _allCars = iAllCars;
            _userManager = userManager;
        }

        [Route("/Cars/List")]
        [Route("/Cars/List/{engineType}")]
        public async Task<ViewResult> List(string engineType)
        {
            var test = await _userManager.GetUserAsync(Request.HttpContext.User);
            engineType = engineType.Replace("{", "").Replace("}", "");
            ViewBag.EngineType = engineType;
            return View(_engineType.EngineTypes.FirstOrDefault(x => x.GroupName.Equals(engineType))?.Cars.OrderBy(x => x.Brand).ToList());
        }

        [Route("/Cars/ChosenMark/{engineType}/{mark}")]
        public ViewResult ChosenMark(string mark, string engineType)
        {
            mark = mark.Replace("{", "").Replace("}", "");
            engineType = engineType.Replace("{", "").Replace("}", "");
            
            return View(_engineType.EngineTypes.FirstOrDefault(x => x.GroupName.Equals(engineType))?.Cars.Where(x => x.Brand.Equals(mark)));
        }

        
        [Route("/Cars/SortPrice/{engine}")]
        public ViewResult SortPrice(string engine)
        {
            ViewBag.EngineType = engine;
            if(string.IsNullOrEmpty(engine)) return View(_allCars.Cars.OrderBy(x => x.RecommendPrice));
            else
            {
                engine = engine.Replace("{", "").Replace("}", "");
                return View(_engineType.EngineTypes.FirstOrDefault(x => x.GroupName.Equals(engine))?.Cars
                    .OrderBy(x => x.RecommendPrice));
            }
        }
        
        [Route("/Cars/SortYear/{engine}")]
        public ViewResult SortYear(string engine)
        {
            ViewBag.EngineType = engine;
            if(string.IsNullOrEmpty(engine)) return View(_allCars.Cars.OrderBy(x => x.RecommendPrice));
            else
            {
                engine = engine.Replace("{", "").Replace("}", "");
                return View(_engineType.EngineTypes.FirstOrDefault(x => x.GroupName.Equals(engine))?.Cars
                    .OrderBy(x => x.StartYear));
            }
        }
    }
}