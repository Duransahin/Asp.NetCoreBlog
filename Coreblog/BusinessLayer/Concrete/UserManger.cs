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
    public class UserManger : IUserService
    {
        IUserDal _userDal;

        public UserManger(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            return _userDal.GetbyId(id);
        }

        public void TUptade(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}
