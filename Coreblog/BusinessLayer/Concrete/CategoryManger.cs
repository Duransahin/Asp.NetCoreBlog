using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManger : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetbyId(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void TUptade(Category category)
        {
            _categoryDal.Update(category);
        }


        

        //public void CategoryAdd(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category);
        //}

        //public void CategoryUptade(Category category)
        //{
        //    _categoryDal.Update(category);
        //}

        //public Category GetById(int id)
        //{
        //    return _categoryDal.GetbyId(id);
        //}



        //public List<Category> GetList()
        //{
        //    return _categoryDal.GetListAll();
        //}
    }
}
