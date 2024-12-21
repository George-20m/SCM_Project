using System.Web.Mvc;
using Client1.FirstWebServiceReference;// Ensure you use the correct namespace

namespace client.Controllers
{
    public class HomeController : Controller
    {
        // Use the auto-generated proxy class
        client.FirstWebServiceClient client = new FirstWebServiceClient();

        public ActionResult Index()
        {
            // Call the WCF service operation
            int result = client.add(5, 3); // Example: call the 'add' method
            ViewBag.Message = $"Addition result: {result}";
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
