using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCore_MVC_EF.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Serilog;

namespace AspNetCore_MVC_EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Log.Information("HomeController.Index wurde aufgerufen");
            return View();
        }

        public IActionResult Privacy()
        {

            string name = HttpContext.Session.GetString("Name");
            int age = HttpContext.Session.GetInt32("Age").Value;

            string jsonString = HttpContext.Session.GetString("neuerBlock");
            Blog blog = JsonSerializer.Deserialize<Blog>(jsonString);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
