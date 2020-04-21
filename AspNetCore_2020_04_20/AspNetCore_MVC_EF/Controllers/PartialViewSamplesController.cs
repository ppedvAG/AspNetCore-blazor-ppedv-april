using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC_EF.Data;
using AspNetCore_MVC_EF.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_EF.Controllers
{
    public class PartialViewSamplesController : Controller
    {
        private readonly BlogDbContext _context;

        public PartialViewSamplesController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartialViewBasicSample()
        {
            return View();
        }

        public IActionResult ShowPartialWithViewModel()
        {
            BlogCommentViewModel vm = new BlogCommentViewModel();

            vm.Blogs = _context.Blog.ToList();
            vm.Comments = _context.Comment.ToList();


            return View(vm);
        }

        public IActionResult LoadPartialOverGetMethod()
        {
            return View();
        }

        public IActionResult OnGetMyPartial() =>
            new PartialViewResult
            {
                ViewName = "_Address",
                ViewData = ViewData,
            };



    }
}