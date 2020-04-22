using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC_EF.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_EF.Controllers
{
    public class DynamicViewController : Controller
    {
        private readonly BlogDbContext _context;

        public DynamicViewController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DynamicViewSample()
        {
            dynamic myDynamicModel = new ExpandoObject();

            myDynamicModel.Blogs = _context.Blog.ToList();
            myDynamicModel.Comments = _context.Comment.ToList();


            return View(myDynamicModel);
        }
    }
}