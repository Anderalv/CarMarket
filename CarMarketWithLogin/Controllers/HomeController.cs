﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarMarketWithLogin.Models;

namespace CarMarketWithLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllCars _allCars;

        public HomeController(ILogger<HomeController> logger, IAllCars allCars)
        {
            _logger = logger;
            _allCars = allCars;
        }
        
        public IActionResult Index()
        {
            return View(_allCars.Cars.OrderBy(x => x.Brand));
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
    }
}