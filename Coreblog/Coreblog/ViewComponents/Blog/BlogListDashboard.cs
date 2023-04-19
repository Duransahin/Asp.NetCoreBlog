using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManger bm = new BlogManger(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListCategory();
            return View(values);
        }

    }
}
