using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManger : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManger(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }


        public Blog TGetById(int id)
        {

            return _blogDal.GetbyId(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void TDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void TUptade(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetBlogListCategory()
        {
            return _blogDal.GetListCategory();
        }

        public List<Blog> BlogCategoryWriterList(int id) // KArıştırma burada kategorileri ıd olarka çekip SelectListItem üzerinden dropdown ile listeliyoruz. 
        {
            return _blogDal.GetListCategoryByWriter(id);
        }

        public List<Blog> GetByBlogID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
           
            return _blogDal.GetListAll(x => x.WriterID == id);

        }





















}
    }

