using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    //Tells view() to look in home folder
    public class HomeController : Controller
    {
        // //http://localhost:5000/home/hello
        // public string Hello() { return "Hello frienddddddddddddddd!"; }
        // //http://localhost:5000/home/goodbye
        // public string Goodbye() { return "Goodbye friendddddddddddddd."; }

        //http://localhost:5000/hello
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }
        //http://localhost:5000/goodbye
        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        // [Produces("text/html")]

        //http://localhost:5000/letter
        [Route("/letter")]
        public ActionResult Letter()
        {
          // Looks for a template with the same name as its parent method
          // return that template as an object of the type ActionResult
          return View();
        }

        //http://localhost:5000/journal
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
    }
}
