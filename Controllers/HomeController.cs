using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            // ViewBag.MyName = "Blair";
            // ViewBag.DojoLocation = "Bellevue";

            return View();
        }
        [HttpPost("result")]
        public ViewResult Result(Survey fromForm)
        {   
            // ViewBag.name = name;
            // ViewBag.dojo = dojo;
            // ViewBag.language = language;
            // ViewBag.comment = comment;
            //Survey result  = new Survey( name, dojo, language, comment);
            
            if(ModelState.IsValid)
            {
                return View(fromForm);
            }
            else
            {
                return View("index");
            }
        }
        
        
        // Other route examples
        [HttpGet]
        [Route("{name}")]
        public string Index(string name)
        {
            return $"Hello {name}!";
        }

        [HttpGet]
        [Route("pizza/{topping}")]
        public string PizzaParty(string topping)
        {
            return $"Who's ready for a {topping} Pizza!";
        }
        [HttpGet]
        [Route("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }
    }
}