using Business.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository _efCategoryRepository;

        public CategoryManager()
        {
            _efCategoryRepository = new EFCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.GetListAll();
        }
    }
}
