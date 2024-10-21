using Microsoft.AspNetCore.Mvc;
using WebUI.Areas.Admin.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                CategoryName = "Technology",
                CategoryCount = 10
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Software",
                CategoryCount = 5
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Sport",
                CategoryCount = 10
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Games",
                CategoryCount = 2
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Book",
                CategoryCount = 9
            });
            return Json(new { jsonlist = list });
        }
    }
}
