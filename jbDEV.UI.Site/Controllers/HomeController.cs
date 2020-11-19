using Microsoft.AspNetCore.Mvc;

namespace jbDEV.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
