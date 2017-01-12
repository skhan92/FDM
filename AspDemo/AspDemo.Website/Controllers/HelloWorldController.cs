using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDemo.Website.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld 
        public ActionResult Index()
        {
            return View();
        }

        public string England()
        {
            return "Hello World!";
        }

        public string France() //Here France is the method/action
        {
            return "Bonjour tout le monde!";
        }
    }
}

//Name of method and controller will determine what view is returned. It will look for the HelloWorld folder in views and return the view for the method called.
//e.g. if new method called home it will go into the helloworld folder in views and return the home view.