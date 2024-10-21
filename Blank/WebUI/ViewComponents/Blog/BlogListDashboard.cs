using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBLogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
