using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class NewsLetterController : Controller
    {

        NewsLetterManager _newsLetterManager = new NewsLetterManager(new EFNewsLetterRepository());

        [HttpGet]   
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            _newsLetterManager.NewsLetterAdd(newsLetter);
            return RedirectToAction("Index", "Blog");
        }
    }
}
