using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryDal
    {
        Context _context = new Context();
        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
