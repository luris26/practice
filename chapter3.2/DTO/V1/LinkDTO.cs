using Microsoft.AspNetCore.Mvc;

namespace chapter3._2.DTO.V1
{
    public class LinkDTO : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
