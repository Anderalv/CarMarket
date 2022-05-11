using System;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarInfoController : Controller
    {
        private readonly IAllCars _allCars;

        public CarInfoController(IAllCars iAllCars){
            _allCars = iAllCars;
        }

        [Route("/CarInfo/InfoAbout/{model}")] 
        public ViewResult InfoAbout(string model)
        {
            model = model.Replace("{", "").Replace("}", "");
            
            var car = _allCars.Cars.FirstOrDefault(x => x.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase));

            return View(car);
        }
    }
}