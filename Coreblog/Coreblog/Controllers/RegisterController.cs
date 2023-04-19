using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    public class RegisterController : Controller
    {
        WriterManger wm = new WriterManger(new EfWriterRepository());
        WriterValidator wv = new WriterValidator();

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        
        
        [HttpPost]
        public IActionResult Index(Writer writer )
        {
            ValidationResult results = wv.Validate(writer);
            if (results.IsValid)
            {
                writer.WriterStatus = true;
                wm.Add(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
