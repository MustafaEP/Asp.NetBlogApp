using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
	public class ContactController : Controller
	{
		ContactManager _contactManager = new ContactManager(new EFContactRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact c)
		{
			c.ConctactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			c.ContactStatus = true;
			_contactManager.ConctactAdd(c);


			return RedirectToAction("index", "blog");
		}
	}
}
