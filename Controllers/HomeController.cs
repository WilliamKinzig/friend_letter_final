using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
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
        [Route("/")]
        public ActionResult Letter()
        {
          return View();
        }
    }
}
