using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManger nlm = new NewsLetterManger(new EfNewsLetterRepository());



        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nlm.AddNewsLetter(newsLetter);
            return PartialView();
        }

        //[HttpGet]
        //public PartialViewResult SubscribeMail()
        //{
        //    return PartialView();
        //}
        //[HttpPost]
        //public IActionResult SubscribeMail(NewsLetter newsLetter)
        //{
        //    newsLetter.MailStatus = true;
        //    nlm.AddNewsLetter(newsLetter);
        //    return RedirectToAction("Index", "Blog");
        //}
    }
}
