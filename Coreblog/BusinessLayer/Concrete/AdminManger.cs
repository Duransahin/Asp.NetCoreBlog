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
    public class AdminManger : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManger(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin t)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Admin t)
        {
            throw new NotImplementedException();
        }

        public Admin TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUptade(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
