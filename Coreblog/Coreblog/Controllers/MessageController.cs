using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
    public class MessageController : Controller
    {
        Message2Manger mm = new Message2Manger(new EfMessage2Repository());

        Context c = new Context();
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetInBoxListByWriter(writerID);
            return View(values);
        }


        public IActionResult MessageDetails(int id)
        {
            var values = mm.TGetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        public IActionResult SendBox()
        {//burada kaldım
            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetListSendBoxMessageByWriter(writerID);
            return View(values);
        }


        [HttpPost]
        public IActionResult SendMessage(Message2 message2)
        {

            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            message2.SenderID = writerID;
            //var result = c.Writers.Where(x => x.WriterMail == message2).Select(y => y.WriterId).FirstOrDefault();
            message2.ReceiverID = 6;
            message2.MessageStatus = true;
            message2.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.Add(message2);


            return RedirectToAction("InBox");
        }
    }
}
