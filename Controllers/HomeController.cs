using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

//Tells view() to look in home folder
namespace FriendLetter.Controllers
{
      public class HomeController : Controller
      {

        // //http://localhost:5000/home/hello
        // public string Hello() { return "Hello frienddddddddddddddd!"; }
        // //http://localhost:5000/home/goodbye
        // public string Goodbye() { return "Goodbye friendddddddddddddd."; }

        // [Route("/")]
        // //To be used in our Hello.cshtml with RAZOR view engine
        // public ActionResult Hello()
        // {
        //   LetterVariable myLetterVariable = new LetterVariable();
        //   myLetterVariable.SetSender("Mitch");
        //   myLetterVariable.SetRecipient("Jessica");
        //   return View(myLetterVariable);//@Model.GetRecipient() in Hello.cshtml is equal to myLetterVariable
        // }
        [Route("/")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Linaaaaaaaaaaa");
          myLetterVariable.SetSender("Johnnnnnyyyyy");
          return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/greeting_card")]
        public ActionResult greeting_card()
        {
          LetterVariable myLetterVariable = new LetterVariable();

          //selects whatever is entered in our form under the name field.
          myLetterVariable.SetRecipient(Request.Query["recipient"]);
          myLetterVariable.SetSender(Request.Query["sender"]);

          // The first argument is "Hello". This is the name of the template we want the ActionResult to use when compiling the HTML.
          return View("Hello", myLetterVariable);
          // You also see that we never created a file called GreetingCard.cshtml, because by passing the "Hello" argument to the View() method, we were able to reuse a template from another view.
        }

        //http://localhost:5000/hello
        [Route("/hello")]
        public string Hello2() { return "Hello friend!"; }
        //http://localhost:5000/goodbye
        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

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
