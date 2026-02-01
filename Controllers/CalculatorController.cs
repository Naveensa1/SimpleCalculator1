using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double number1, double number2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "Add":
                    result = number1 + number2;
                    break;
                case "Subtract":
                    result = number1 - number2;
                    break;
                case "Multiply":
                    result = number1 * number2;
                    break;
                case "Divide":
                    result = number2 != 0 ? number1 / number2 : 0;
                    break;
            }
            ViewBag.Result = result;
            return View();
        }
    }
}
