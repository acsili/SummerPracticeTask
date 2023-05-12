using FromWebFormToJson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace FromWebFormToJson.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {

            if (person.MiddleName == null || person.FirstName == null || person.LastName == null || person.BirthDate == null)
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
