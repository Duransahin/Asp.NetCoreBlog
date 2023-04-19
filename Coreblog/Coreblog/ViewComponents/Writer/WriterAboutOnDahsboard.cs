using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.ViewComponents.Writer
{
   
    public class WriterAboutOnDahsboard:ViewComponent
    {
        WriterManger wm = new WriterManger(new EfWriterRepository());
        private readonly UserManager<AppUser> _userManager;
        Context c = new Context();

        public WriterAboutOnDahsboard(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public  IViewComponentResult Invoke()
        {
            //var user = await _userManager.FindByIdAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.b = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterListByID(writerID);
            return View(values);
        }
    }
}
