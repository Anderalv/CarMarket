using System;
using System.Collections.Generic;
using System.Linq;
using CarMarketWithLogin.Data;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CarMarketWithLogin.Controllers
{
    public class BookMarksController : Controller
    {
        private ApplicationDbContext _applicationDbContext;
        private UserManager<User> _userManager;
        private IAllCars _allCars;
        public BookMarksController(UserManager<User> userManager, ApplicationDbContext applicationDbContext, IAllCars allCars)
        {
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
            _allCars = allCars;
        }

        [Authorize]
        [Route("/test/{carId}")]
        public ViewResult AddBookMark(string carId)
        {
            if (User.Identity.IsAuthenticated)
            {
                carId = carId.Replace("{", "").Replace("}", "");
                int id = Int32.Parse(carId);
                var user = HttpContext.User;
                var name = user.Identity.Name;
                var currentUser =  _userManager.Users.FirstOrDefault(x => x.Email.Equals(name));

                if (_applicationDbContext.BookMarks.Any(x => x.User.Equals(currentUser) && x.CarId == id))
                {
                    return View(true);
                }
                
                BookMark newBookMark = new BookMark
                {
                    CarId = id,
                    User = currentUser
                };

                // currentUser.BookMarks.Add(newBookMark);
                
                _applicationDbContext.BookMarks.Add(newBookMark);
                _applicationDbContext.SaveChanges();
            }
            return View();
        }

        [Route("/BookMarks/AllBookMarks")]
        public ViewResult AllBookMarks()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User;
                var name = user.Identity.Name;
                var currentUser =  _userManager.Users.FirstOrDefault(x => x.Email.Equals(name));

                var bookMarks = _applicationDbContext.BookMarks.Where(x => x.User
                    .Equals(currentUser)).ToList();

                List<Car> cars = new List<Car>();

                foreach (var item in bookMarks)
                {
                    var car = _allCars.Cars.First(x => x.Id == item.CarId);
                    cars.Add(car);
                }

                return View(cars);
            }
            return View();
        }

        
        [Route("/BookMark/Delete/{CarId}")]
        public RedirectToActionResult DeleteBookMark(string carId)
        {
            carId = carId.Replace("{", "").Replace("}", "");
            var id = int.Parse(carId);
            
            var user = HttpContext.User;
            var name = user.Identity.Name;
            var currentUser =  _userManager.Users.FirstOrDefault(x => x.Email.Equals(name));

            var bookMark = _applicationDbContext.BookMarks.FirstOrDefault(x => x.User
                .Equals(currentUser) && x.CarId == id);

            if (bookMark is not null)
            {
                _applicationDbContext.BookMarks.Remove(bookMark);
                _applicationDbContext.SaveChanges();
            }

            return RedirectToAction("AllBookMarks", "BookMarks");
        }
        
    }
}