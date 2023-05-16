using FromWebFormToJson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FromWebFormToJson.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult AddPerson() => View();
        
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                TempData["msg"] = "Fill in all the fields";
                return View();
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(person, options);
            System.IO.File.WriteAllText("person.json", json);

            TempData["msg"] = "Added successfully";

            return View();
        }
    }
}
