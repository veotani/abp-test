using System.Web.Mvc;

namespace ABPTest.Web.Controllers
{
    public class HomeController : ABPTestControllerBase
    {
        public ActionResult Index()
        { 
            return View(); //Layout of the angular application.
        }
	}
}