using Microsoft.AspNetCore.Mvc;

namespace EjerciciosASP_Unidad7.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        public static DateTime getTime() {
            DateTime time = DateTime.Now;
            return time;
        }

        public static int getHour(DateTime time) {
            int hour = time.Hour;
            return hour;
        }

        public static string welcomeMessage() {
            string welcome = "Welcome!";
            DateTime time = getTime();
            int hour = getHour(time);
            if (hour < 12)
            {
                welcome = "Good Morning!";
            }
            else if (hour > 12 && hour < 18)
            {
                welcome = "Good Afternoon!";
            }
            else {
                welcome = "Good Evening!";
            }
            return welcome;
        }

    }
}