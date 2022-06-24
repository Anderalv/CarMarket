using System;
using System.Globalization;
using System.Linq;
using CarMarketWithLogin.Data;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class CarInfoController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ApplicationDbContext _content;
        private readonly UserManager<User> _userManager;

        public CarInfoController(IAllCars iAllCars,ApplicationDbContext content, UserManager<User> userManager)
        {
            _allCars = iAllCars;
            _content = content;
            _userManager = userManager;
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
            
            var user = HttpContext.User;  
            var name = user.Identity.Name; 
            var currentUser = _userManager.Users.FirstOrDefault(x => x.Email.Equals(name));
            model = model.Replace("{", "").Replace("}", "");
            var car = _allCars.Cars.FirstOrDefault(x =>
                    x.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase)); 

            var newComment = new Comment(); 
            newComment.Tenure = tenure;
            newComment.Data = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            newComment.Content = inputComment;
            
            newComment.Car = car;
            newComment.User = currentUser;
            
            _content.Comments.Add(newComment);
            _content.Users.First(x => x.Id.Equals(currentUser.Id)).Comments.Add(newComment);

            var test = _content.Users.First(x => x.Id.Equals(currentUser.Id)).Comments.First().Car.Brand;
            
            _content.SaveChanges();

            return View(car);
        }
    }
}