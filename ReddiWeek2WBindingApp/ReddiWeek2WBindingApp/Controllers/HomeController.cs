using Microsoft.AspNetCore.Mvc;
// Created by Satya Praneeth Reddi
// 2222222222222222222222222222222
namespace ReddiWeek2WBindingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } // Index()
        
        [HttpPost]
        public IActionResult Index(int number)
        {
            if (ModelState.IsValid)
            {
                int result = (int)Math.Pow(number, 2);
                ViewBag.Result = $"You entered {number}, Square of {number} is {result}";
            } // Validity check
            return View("Index");
        } // FindSquare()

        public IActionResult ShowFortune(int number, string name)
        {
            if (ModelState.IsValid)
            {
                string fortune;
                switch (number)
                {
                    case 0:
                        fortune = "Drink deeply. Live in serenity and joy.";
                        break;
                    case 1:
                        fortune = "Live in joy, without possessions, like the shining ones.";
                        break;
                    case 2:
                        fortune = "If you love a flower, don’t pick it up. Because if you pick it up it dies and it ceases to be what you love. So if you love a flower, let it be. Love is not about possession. Love is about appreciation.\r\n\r\nRead more at: https://yourstory.com/mystory/osho-quotes-grow-your-wisdom";
                        break;
                    case 3:
                        fortune = "Life begins where fear ends.";
                        break;
                    case 4:
                        fortune = "Creativity is the greatest rebellion in existence.";
                        break;
                    case 5:
                        fortune = "My meditation is simple. It does not require any complex practices. It is simple. It is singing. It is dancing. It is sitting silently";
                        break;
                    default:
                        fortune = "Be — don't try to become";
                        break;
                } // switch
                ViewBag.Result = name + ", " + fortune;
            } // model state validity
            else ViewBag.Result = "Invalid Input. Please try again.";
            return View("Index");
        } // ShowFortune()

    } // class
} // namespace
