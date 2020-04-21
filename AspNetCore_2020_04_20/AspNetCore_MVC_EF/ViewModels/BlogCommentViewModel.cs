using AspNetCore_MVC_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC_EF.ViewModels
{
    public class BlogCommentViewModel
    {
        public IList<Blog> Blogs { get; set; }

        public IList<Comment> Comments { get; set; }

    }
}
