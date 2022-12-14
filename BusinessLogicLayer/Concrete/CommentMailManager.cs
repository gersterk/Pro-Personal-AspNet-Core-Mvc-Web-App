using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class CommentMailManager : ICommentMailService
    {
        ICommentMailDal _commentMailDal;

        public CommentMailManager(ICommentMailDal commentMailDal)
        {
            _commentMailDal = commentMailDal;
        }

        public void CommentAdd(CommentMail comment)
        {
            _commentMailDal.Insert(comment);
        }

        public List<CommentMail> GetCommentsByBlog()
        {
           return _commentMailDal.GetListByBlog();

        }

        public List<CommentMail> GetList(int id)
        {
            return _commentMailDal.GetAllList(x => x.BlogId == id);

        }

    }
}
