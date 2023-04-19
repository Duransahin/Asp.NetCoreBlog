using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Areas.Admin.ViewComponents.İstatistik
{

    public class İstatistik1:ViewComponent
    {
        BlogManger bm = new BlogManger(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {//Toplam Blog sayısıı tutum
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            return View();
        }
    }
}
