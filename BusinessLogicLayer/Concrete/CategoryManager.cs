using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;


namespace BusinessLogicLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        //EfCategoryRepository efCategory;
        //I give up on EfRepo because then I would be very much depend on it
        //So I to go for Interface

        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category TGetById(int id)
        { 
            return _categoryDal.GetById(id);
        }        

        public List<Category> GetList()
        {
            return _categoryDal.GetAllList();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);

        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);

        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
