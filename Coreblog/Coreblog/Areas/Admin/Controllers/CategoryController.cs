using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Coreblog.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManger cm = new CategoryManger(new EfCategoryRepository());
        Context c = new Context();
        CategoryValidator cv = new CategoryValidator();

        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page,3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            ValidationResult result = cv.Validate(category);
            //var userMail = User.Identity.Name;
            //var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            if (result.IsValid)
            {
                category.CategoryStatus = true;
                cm.Add(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }

        public IActionResult CategoryDelete(int id)
        {
            var blogValues = cm.TGetById(id);
            cm.TDelete(blogValues);
            return RedirectToAction("Index");
        }
    }
}
