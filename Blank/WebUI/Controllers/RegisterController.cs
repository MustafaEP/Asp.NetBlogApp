using Business.Abstract;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());


        [HttpGet]
        public IActionResult Index()
        {
            var cities = _cityManager.GetList();
            var values = new RegisterViewModel
            {
                Cities = cities
            };
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(RegisterViewModel registerViewModel)
        {
            WriterValidator wr = new WriterValidator();
            ValidationResult result = wr.Validate(registerViewModel.Writer);
            if(result.IsValid)
            {
                registerViewModel.Writer.WriterStatus = true;
                registerViewModel.Writer.WriterAbout = "Try Test";
                _writerManager.WriterAdd(registerViewModel.Writer); 
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                registerViewModel.Cities = _cityManager.GetList();
            }
            
            
            
            return View(registerViewModel);

        }

    }
}
