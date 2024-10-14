using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());

        public IActionResult Index()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
    }
}
