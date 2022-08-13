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
        //So I to go for Interfase

        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);

        }

        public Category GetById(int id)
        { 
            return _categoryDal.GetById(id);
        }        

        public List<Category> GetList()
        {
            return _categoryDal.GetAllList();
        }
    }
}
