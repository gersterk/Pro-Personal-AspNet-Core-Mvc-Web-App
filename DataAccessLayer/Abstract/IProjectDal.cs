using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProjectDal : IGenericDal<Project>
    {
        public void Delete(Project t)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllList(Expression<Func<Project, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Project t)
        {
            throw new NotImplementedException();
        }

        public void Update(Project t)
        {
            throw new NotImplementedException();
        }
    }
}
