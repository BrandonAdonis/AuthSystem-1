using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult SchoolSubjects()
        {
            return View();
        }
        public IActionResult Teachers()
        {
            return View();
        }

        public IActionResult English()
        {
            return View();
        }

        public IActionResult Math() 
        {
            return View();
        }
        public IActionResult Technologies()
        {
            return View();
        }
        public IActionResult PhyicalEdu()
        {
            return View();
        }
        public IActionResult Sciences()
        {
            return View();
        }
        public IActionResult NCEA()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult CIE()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }
        public IActionResult Pathways()
        {
            return View();
        }
        public IActionResult OnlineLearning()
        {
            return View();
        }
        public IActionResult Junior()
        {
            return View();
        }
        public IActionResult Resources()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult AvcolMathletes()
        {
            return View();
        }
        public IActionResult Revision()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}