using Microsoft.AspNetCore.Mvc;
using ReddiWeek2WLawnMowers.Models;

namespace ReddiWeek2WLawnMowers.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Created by Satya Praneeth Reddi
         * 2222222222222222222
         */
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] // This annotation is for the method to fire only on post method.
        public IActionResult Index(MowersModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NumberOfWeeks < 1 || model.NumberOfWeeks > 20)
                {
                    ModelState.AddModelError("NumberOfWeeks", "must be between 1 and 20.");
                }
                else if (model.Area < 1000 || model.Area > 500000)
                {
                    ModelState.AddModelError("Area", "Must be between 1000 and 500000");
                }

                model.CalculateQuote(); // Call the model method to calculate quote.
                return View("LawnQuote", model);
            }
            return View("Index", model);
        }
    }
}
