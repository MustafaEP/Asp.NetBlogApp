using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NatificationManager natificationManager = new NatificationManager(new EFNatificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = natificationManager.GetList();
            return View(values);
        }
    }
}

