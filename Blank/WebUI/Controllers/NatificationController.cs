using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class NatificationController : Controller
    {

        NatificationManager natificationManager = new NatificationManager(new
            EFNatificationRepository());

        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult AllNatification()
        {
            var values = natificationManager.GetList();
            return View(values);
        }
    }
}
