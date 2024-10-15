using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Security.Claims;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();
            var dataValue = context.Writers.FirstOrDefault(x => x.WriterEMail == writer.WriterEMail &&
            x.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, writer.WriterEMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
		}
	}
}

//Context context = new Context();
//var dataValue = context.Writers.FirstOrDefault(x => x.WriterEMail == writer.WriterEMail &&
//x.WriterPassword == writer.WriterPassword);

//if (dataValue != null)
//{
//	HttpContext.Session.SetString("username", writer.WriterEMail);
//	return RedirectToAction("index", "writer");
//}
//else
//{
//	return View();
//}
