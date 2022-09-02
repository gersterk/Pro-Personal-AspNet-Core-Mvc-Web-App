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
    public class BusinessCardManager : IBusinessCardService
    {
        IBusinessCardDal _businessCardDal; 

        public BusinessCardManager(IBusinessCardDal businessCardDal)
        {
            _businessCardDal = businessCardDal; 
        }

        public List<BusinessCard> GetList()
        {
            return _businessCardDal.GetAllList();
        }

        public void TAdd(BusinessCard t)
        {
            _businessCardDal.Insert(t);
        }

        public void TDelete(BusinessCard t)
        {
            _businessCardDal.Delete(t);

        }

        public BusinessCard TGetById(int id)
        {
            return _businessCardDal.GetById(id);
        }

        public void TUpdate(BusinessCard t)
        {
            _businessCardDal.Update(t);

        }
    }
}
