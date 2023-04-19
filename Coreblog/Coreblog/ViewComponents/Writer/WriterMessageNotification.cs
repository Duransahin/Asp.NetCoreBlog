using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manger mm = new Message2Manger(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;

            var values = mm.GetInBoxListByWriter(id);
            return View(values);
        }
    }
}
