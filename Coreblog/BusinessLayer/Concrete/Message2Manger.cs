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
    public class Message2Manger : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manger(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void Add(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public List<Message2> GetInBoxListByWriter(int id)
        {
            return _message2Dal.GetListMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
          return  _message2Dal.GetListAll();
        }

        public List<Message2> GetListSendBoxMessageByWriter(int id)
        {
            return _message2Dal.GetListSendBoxMessageByWriter(id);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _message2Dal.GetbyId(id);
        }

        public void TUptade(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
