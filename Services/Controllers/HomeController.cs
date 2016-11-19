using System.Web.Mvc;

namespace DotnetWebScaffold.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}