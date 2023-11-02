using EjerciciosASP_Unidad7.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosASP_Unidad7.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() {
            string welcome = "";
            DateTime time = DateTime.Now;
            int hour = time.Hour;
            if (hour < 12)
            {
                welcome = "Good Morning!";
            }
            else if (hour >= 12 && hour < 18)
            {
                welcome = "Good Afternoon!";
            }
            else
            {
                welcome = "Good Evening!";
            }
            ViewData["Welcome"] = welcome;
            ViewBag.time = time;
            List<Person> people = new List<Person>
            {
                new Person {id = 1, firstName = "Alessandro", lastName = "Leotta", age = 21},
                new Person {id = 2, firstName = "John", lastName = "Shepard", age = 35},
                new Person {id = 3, firstName = "Jane", lastName = "Shepard", age = 32}
            };
            //Person p1 = new Person();
            //p1.id = 1;
            //p1.firstName = "Alessandro";
            //p1.lastName = "Leotta";
            //p1.age = 21;
            return View(people);
        }

    }
}