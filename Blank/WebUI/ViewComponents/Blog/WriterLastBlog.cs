using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EFBLogRepository());

		public IViewComponentResult Invoke()
		{
			var values = _blogManager.GetBlogByWriter(1);
			return View(values);
		}
	}
}
