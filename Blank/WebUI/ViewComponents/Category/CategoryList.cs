using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());
        
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
    }
}
