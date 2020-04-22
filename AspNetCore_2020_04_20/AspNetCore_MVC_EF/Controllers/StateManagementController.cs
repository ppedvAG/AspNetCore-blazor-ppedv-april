using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AspNetCore_MVC_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCore_MVC_EF.Controllers
{
    public class StateManagementController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        #region TempData
        public IActionResult TempDataFirst()
        {
            TempData["UserId"] = 101;
            

            return View();
        }

        public IActionResult TempDataSecond()
        {
            var userId = TempData["UserId"] ?? null;

            return View();
        }

        public IActionResult TempThird()
        {
            var userId = TempData["UserId"] ?? null;

            return View();
        }
        #endregion TempData

        public IActionResult ViewDataSample()
        {
            ViewData["CoronaId"] = 123;
            return View();
        }

        public IActionResult ViewBagSample()
        {
            ViewBag.UserId = 101;
            ViewBag.Name = "John";
            ViewBag.Age = 31;

            return View();
        }

        public IActionResult SessionInit()
        {
            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);

            Blog blog = new Blog();
            blog.Title = "Microsoft Developer Magazin wurde eingestellt";
            blog.Content = "Seit November 2019 bringt Microsoft sein Entwicklermagazin nicht mehr heraus";
            blog.CreatedAt = DateTime.Now;
            blog.CreatedBy = "Bill Gates";
            blog.Id = 111;

            string jsonString = JsonSerializer.Serialize(blog);
            HttpContext.Session.SetString("neuerBlock", jsonString);

            return View();
        }

        public IActionResult SessionRead()
        {
            string name = HttpContext.Session.GetString("Name");
            int age = HttpContext.Session.GetInt32("Age").Value;

            string jsonString = HttpContext.Session.GetString("neuerBlock");
            Blog blog = JsonSerializer.Deserialize<Blog>(jsonString);

            return View();
        }
    }
}