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
    public class AboutManger:IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManger(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUptade(About t)
        {
            throw new NotImplementedException();
        }

        //public List<About> GetList()
        //{
        //    return _aboutDal.GetListAll();
        //}
    }
}
