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
            return View();
        }

    }
}