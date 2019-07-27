using Microsoft.AspNetCore.Mvc;

namespace SIGamePacks.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index", "Packs");
        }
    }
}