using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void TDelete(T t);
        void TUptade(T t);
        T TGetById(int id); 
        List<T> GetList();
    }
}
