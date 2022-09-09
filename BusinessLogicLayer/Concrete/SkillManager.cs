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
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public List<Skill> GetList()
        {
            return _skilldal.GetAllList();

        }

        public void TAdd(Skill t)
        {
            _skilldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skilldal.Update(t);
        }
    }
}
