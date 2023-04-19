using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManger cm = new CategoryManger(new EfCategoryRepository()); 
        public IActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
    }
}
