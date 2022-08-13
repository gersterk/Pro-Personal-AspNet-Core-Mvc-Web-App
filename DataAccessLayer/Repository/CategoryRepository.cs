using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.GenericRepository
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();


        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();

        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();

        }

        public List<Category> GetAllCategories()
        {
            return c.Categories.ToList();

        }

        public Category GetCategoryById(int id)
        {
            return c.Categories.Find(id);


        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();

        }
    }
}
