using Microsoft.AspNetCore.Mvc;

//Created by Satya Praneeth Reddi

namespace ReddiWeek1W.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // declaring several variables for passing messages to the view.

            // get the year into a variable
            int year = DateTime.Now.Year;

            // welcome message
            String welcome = $"Welcome to CIS 5612-Serverside Internet Resources - Summer {year}";

            //daily quote
            String quote = "Talent is cheaper than table salt. What seperates a talented individual " +
                "from the successful one is a lot of hardwork -- Stephen King";

            //send the above quotes and messages to the view: using ViewData.
            //view data is a key-value pair or a c# dictionary.

            ViewData["welcome"] = welcome;
            ViewData["quote"] = quote;

            //see it is returning a method called View() which does not have any arguments. 
            //What view is it returning? -- it is returning a view that has the same
            //name as the method (index)
       

            return View();  //absolute last line of the code
        } // Closing the Index()
    } // Controller
} // namespace
