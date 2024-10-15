using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
	public class AboutController : Controller
	{
		AboutManager _aboutManager = new AboutManager(new EFAboutRepository());

		public IActionResult Index()
		{
			var values = _aboutManager.GetList();
			return View(values);
		}

		public PartialViewResult SocialMediaAbout()
		{
			
			return PartialView();
		}
	}
}
