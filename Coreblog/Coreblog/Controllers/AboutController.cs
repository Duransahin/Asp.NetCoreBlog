using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    public class AboutController : Controller
    {
        AboutManger abm = new AboutManger(new EfAboutRepository());
        public IActionResult Index()
        {
            var aboutValues = abm.GetList();
            return View(aboutValues);
        }
    }
}
