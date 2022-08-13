using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
        public void Delete(CommentMail t)
        {
            throw new NotImplementedException();
        }

        public void Insert(CommentMail t)
        {
            throw new NotImplementedException();
        }

        public void Update(CommentMail t)
        {
            throw new NotImplementedException();
        }

        List<CommentMail> IGenericDal<CommentMail>.GetAllList()
        {
            throw new NotImplementedException();
        }

        CommentMail IGenericDal<CommentMail>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
