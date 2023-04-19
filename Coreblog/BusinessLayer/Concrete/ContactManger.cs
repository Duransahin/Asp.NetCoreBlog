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
    public class ContactManger : IContactService
    {
        
        IContactDal _contactDal;

        public ContactManger(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContatAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }
    }
}
