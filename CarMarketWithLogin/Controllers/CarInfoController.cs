using System;
using System.Globalization;
using System.Linq;
using CarMarketWithLogin.Data;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarInfoController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ApplicationDbContext _content;

        public CarInfoController(IAllCars iAllCars,ApplicationDbContext content)
        {
            _allCars = iAllCars;
            _content = content;
        }

        
        
        [HttpGet]
        [Route("/CarInfo/InfoAbout/{model}")] 
        public IActionResult InfoAbout(string model)
        {
            model = model.Replace("{", "").Replace("}", "");
            
            var car = _allCars.Cars.FirstOrDefault(x => x.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase));

            return View(car);
        }
        
        [HttpPost]
        [Route("/CarInfo/InfoAbout/{model}")] 
        public IActionResult InfoAbout(string inputComment,string tenure, string model)
        {
            model = model.Replace("{", "").Replace("}", "");
           
            var car = _allCars.Cars.FirstOrDefault(x => x.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase));
            
            var newComment = new Comment();
            newComment.Tenure = tenure;
            newComment.Data =DateTime.Now.ToString(CultureInfo.InvariantCulture);
            newComment.Content = inputComment; 
            newComment.Car = car;
            
            car?.Comments.Add(newComment);
            _content.Comments.Add(newComment);
            _content.SaveChanges();
            
            return View(car);
        }
        
    }
}