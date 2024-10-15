using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Blog
{
	public class BlogLast3Post : ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EFBLogRepository());

		public IViewComponentResult Invoke()
		{
			var values = _blogManager.GetList3Blog();
			return View(values);
		}
	}
}
