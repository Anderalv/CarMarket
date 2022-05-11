using System;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarsController : Controller
    {
        private readonly IEngineType _engineType;
        public CarsController(IEngineType iEngineType)
        {
            _engineType = iEngineType;
        }

        [Route("/Cars/List")]
        [Route("/Cars/List/{engineType}")]
        public ViewResult List(string engineType)
        {
            // if (String.IsNullOrEmpty(engineType))
            // {
            //     _engineType.EngineTypes.FirstOrDefault(x => string.IsNullOrEmpty() x.GroupName.Equals(engineType))?.Cars.OrderBy(x => x.Brand).ToList());
            // }
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
    }
}