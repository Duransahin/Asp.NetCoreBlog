using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        //void BlogAdd(Blog blog);
        //void BlogDelete(Blog blog);
        //void BlogUptade(Blog blog);
        //Blog GetById(int id);
        //List<Blog> GetList();
        List<Blog> GetBlogListCategory();
        List<Blog> GetBlogListByWriter(int id);

    }
}
