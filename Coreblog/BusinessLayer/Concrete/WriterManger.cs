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
    public class WriterManger : IWriterService
    {
        IWriterDal _writerDal;
        

        public WriterManger(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterListByID(int id)//***//
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }

        public void TDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetbyId(id);
        }

        public void TUptade(Writer writer)
        {
            _writerDal.Update(writer);
        }

        
    }
}
