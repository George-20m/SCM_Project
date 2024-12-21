using Client1.FirstWebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client1.Controllers
{
    public class HomeController : Controller
    {
        FirstWebServiceClient client = new FirstWebServiceClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.Message();

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