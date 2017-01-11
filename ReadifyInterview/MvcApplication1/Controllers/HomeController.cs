using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            FibonacciController obj = new FibonacciController();
            int inputValue = Convert.ToInt32(collection["nValue"]);
            long a = obj.GetValueAtN(inputValue);
            ViewBag.Value1 = a; 
            return View();
        }
    }
}
