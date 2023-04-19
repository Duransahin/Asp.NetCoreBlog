using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IMessage2Dal : IGenericDal<Message2>
    {
        List<Message2> GetListMessageByWriter(int id); //Burası InBox için kullanılacak isim değişikliğine gidilmedi
        List<Message2> GetListSendBoxMessageByWriter(int id); 
    }
}
