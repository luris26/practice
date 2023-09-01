using Microsoft.AspNetCore.Mvc;

namespace chapter3._2.Controllers.v1
{
    public class practice : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
