using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManger bm = new BlogManger(new EfBlogRepository());
        CategoryManger cm =new  CategoryManger(new EfCategoryRepository());
        Context c = new Context();



        public IActionResult Index()
        {
            var blogValues = bm.GetBlogListCategory();
            return View(blogValues);
        }


        public IActionResult BlogDeatails(int id)
        {
            ViewBag.i = id;
            var values = bm.GetByBlogID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
           
            var values = bm.BlogCategoryWriterList(writerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {


            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem//burada kategorileri string halde listeledik
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();//Web sayası 
        }
        
        
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {

            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.WriterID = writerID;
            bm.Add(blog);
            return RedirectToAction("BlogListByWriter","Blog");
        }


        public IActionResult DeleteBlog(int id)
        {
            var blogValues = bm.TGetById(id);
            bm.TDelete(blogValues);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValues = bm.TGetById(id);
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.cv = categoryValues;

            return View(blogValues);
        }
        
        
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            var userName = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            blog.WriterID = writerID;
            blog.BlogCreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            bm.TUptade(blog);
            
            return RedirectToAction("BlogListByWriter");
        }
    }

}
