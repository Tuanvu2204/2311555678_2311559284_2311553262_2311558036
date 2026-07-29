using Microsoft.AspNetCore.Mvc;

namespace LibraryAdvancedMVC.Controllers
{
    public class MVC_Controller_with_views__using_Entity_Framework : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
