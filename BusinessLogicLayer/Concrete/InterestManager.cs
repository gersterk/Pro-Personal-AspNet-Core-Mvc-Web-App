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
    public class InterestManager : IInterestService
    {
        IInterestDal _interestDal;

        public InterestManager(IInterestDal interestDal)
        {
            _interestDal = interestDal;
        }

        public List<Interest> GetList()
        {
            return _interestDal.GetAllList();
        }

        public void TAdd(Interest t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Interest t)
        {
            throw new NotImplementedException();
        }

        public Interest TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Interest t)
        {
            throw new NotImplementedException();
        }
    }
}
