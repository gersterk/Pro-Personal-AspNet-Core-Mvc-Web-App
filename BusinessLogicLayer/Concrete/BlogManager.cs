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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        } 

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAllList(x =>x.BlogId==id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();

        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListByCategory()
        {
            return _blogDal.GetListByCategory();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListByCategoryWithWriterBm(int id)
        {
            return _blogDal.GetListByCategoryWithWriter(id);
        }
    }
}
