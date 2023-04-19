using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void BlogDelete(Blog blog);
        //void BlogUptade(Blog blog);
        //Blog GetById(int id);
        List<Comment> GetList(int id);
        //List<Blog> GetBlogListCategory();
    }
}
