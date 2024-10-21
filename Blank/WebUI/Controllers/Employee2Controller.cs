using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
    public class Employee2Controller : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7222/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);

            return View(values);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            return View();
        }

        public class Class1
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
