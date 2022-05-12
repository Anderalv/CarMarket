using System.Linq;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarsController : Controller
    {
        private readonly IEngineType _engineType;
        private readonly IAllCars _allCars;
        public CarsController(IEngineType iEngineType, IAllCars iAllCars)
        {
            _engineType = iEngineType;
            _allCars = iAllCars;
        }

        [Route("/Cars/List")]
        [Route("/Cars/List/{engineType}")]
        public ViewResult List(string engineType)
        {
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