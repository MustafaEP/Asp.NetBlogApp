using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = _writerManager.GetWriterById(1);
            return View(values);
        }
    }
}
