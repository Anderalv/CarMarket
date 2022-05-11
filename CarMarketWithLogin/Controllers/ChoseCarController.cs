using System;
using System.Linq;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class ChoseCarController : Controller
    {
        private readonly IAllCars _allCars;

        public ChoseCarController(IAllCars iAllCars){
            _allCars = iAllCars;
        }

        [Route("/ChoseCar/ChosenMark/{mark}")] 
        public ViewResult ChosenMark(string mark)
        {
            mark = mark.Replace("{", "").Replace("}", "");
            
            var cars = _allCars.Cars.Where(x => x.Brand.Equals(mark, StringComparison.CurrentCultureIgnoreCase)).ToList();

            return View(cars);
        } 
        
        [Route("/ChoseMarkCar/ChosenMark/{model}")] 
        public ViewResult ChosenModel(string model)
        {
            model = model.Replace("{", "").Replace("}", "");
            return View(_allCars.Cars.FirstOrDefault(x => x.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase)));
        }
    }
}