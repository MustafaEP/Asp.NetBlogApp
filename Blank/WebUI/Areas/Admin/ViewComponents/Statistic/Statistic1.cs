using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EFBLogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = blogManager.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();


            string api = "71f9f670ba5a4d60adb69d4186874c23";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Bursa&mode=xml&lang=en&units=metric&appid=" + api;

            XDocument document = XDocument.Load(connection);

            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
