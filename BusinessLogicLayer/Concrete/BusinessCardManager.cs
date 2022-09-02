using BusinessLogicLayer.Abstract;
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
        public List<BusinessCard> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(BusinessCard t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(BusinessCard t)
        {
            throw new NotImplementedException();
        }

        public BusinessCard TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(BusinessCard t)
        {
            throw new NotImplementedException();
        }
    }
}
