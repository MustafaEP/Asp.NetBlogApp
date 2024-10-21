using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Admins
                                .Where(x => x.AdminId == 2)
                                .Select(y => y.AdminName)
                                .FirstOrDefault();
            ViewBag.v2 = context.Admins.Where(x => x.AdminId == 2).Select(y => y.AdminImageURL).FirstOrDefault();
            ViewBag.v3 = context.Admins.Where(x => x.AdminId == 2).Select(y => y.AdminShortDescription).FirstOrDefault();
            return View();
        }
    }
}
