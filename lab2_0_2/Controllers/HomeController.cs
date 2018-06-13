using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_0_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    

    [HttpPost]
    public ActionResult Index(string firstNum, string secondNum, String calc)
    {

        double a;
        double b;
        double.TryParse(secondNum, out a);
        double.TryParse(firstNum, out b);
        double c = 0;

        switch (calc)
        {
            case "+":
                c = a + b;
                break;
            case "-":
                c = a - b;
                break;
            case "*":
                c = a * b;
                break;
            case "/":
                c = a / b;
                break;
        }
        b = c;

        ViewBag.secondNum = b;
        ViewBag.Result = c;

        return View();

    }

    public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}