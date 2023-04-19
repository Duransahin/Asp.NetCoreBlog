using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManger nm = new NotificationManger(new EfNotificationRepository() );
        public IActionResult Index()
        {
            return View();
        }
        
        [AllowAnonymous]
        public IActionResult AllNotification()
        {
            var values = nm.GetList();
            return View(values);

        }
    }
}
