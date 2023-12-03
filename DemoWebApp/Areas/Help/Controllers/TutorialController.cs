using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(int id)
        {
            return View("Page" + id);
        }
    }
}
