using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _410_final_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Submit(String firstname, String lastname)
        {
            NameValueCollection nvc = Request.Form;
            String name = nvc["class"];
            return Content("Test");
        }

    }
}