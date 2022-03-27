using Microsoft.AspNetCore.Mvc;

namespace MonPortfolio2022.Controllers
{
    public class BlogController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
