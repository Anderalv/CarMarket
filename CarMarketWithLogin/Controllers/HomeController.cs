﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Identity;
using X.PagedList;


namespace CarMarketWithLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllCars _allCars;
        // private readonly UserManager<IdentityUser> _userManager;
        // RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger, IAllCars allCars /*UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager*/)
        {
            _logger = logger;
            _allCars = allCars;
            // _userManager = userManager;
            // _roleManager = roleManager;
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