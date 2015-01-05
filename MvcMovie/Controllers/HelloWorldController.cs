using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int clas)
        {
            ViewBag.Name = name;
            ViewBag.Clas = clas;
            return View();
        }

        public string Add(int a = 0, int b = 0)
        {
            return HttpUtility.HtmlEncode("The sum is: "+(a+b));
        }

        public string Info(string name = null, int age = 0)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", you are " + age + " years old.");
        }
    }
}