using Microsoft.AspNetCore.Mvc;
using System.Data; // Required for computing strings

namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Calculate(string display)
        {
            try
            {
                var result = new DataTable().Compute(display, null);
                ViewBag.Display = result.ToString();
            }
            catch
            {
                ViewBag.Display = "Error";
            }
            return View("Index");
        }
    }
}
