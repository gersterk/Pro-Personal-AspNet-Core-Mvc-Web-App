using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ICommentMailService
    {
        void CommentAdd(CommentMail comment);
        //void CategoryDelete(Comment comment);
        //void CategoryUpdate(Comment comment);

        List<CommentMail> GetList(int id);
        //CommentMail GetById(int id);

        List<CommentMail> GetCommentsByBlog();

    }
}
