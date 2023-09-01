using Microsoft.AspNetCore.Mvc;

namespace chapter3._2.Controllers.v2
{
    public class BoardGamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
