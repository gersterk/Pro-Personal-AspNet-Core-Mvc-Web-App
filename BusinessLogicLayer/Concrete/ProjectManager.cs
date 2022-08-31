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
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public List<Project> GetList()
        {
            return _projectDal.GetAllList();

        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            throw new NotImplementedException();
        }

        public Project TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);

        }

        public List<Project> GetProjectByIdb(int id)
        {
            return _projectDal.GetAllList(x => x.ProjectId == id);
        }

    }
}
