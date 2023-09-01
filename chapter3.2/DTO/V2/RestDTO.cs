using Microsoft.AspNetCore.Mvc;

namespace chapter3._2.DTO.V2
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
