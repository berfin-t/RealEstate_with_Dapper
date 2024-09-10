using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class WhoWeAreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
