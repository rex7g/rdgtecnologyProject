using Microsoft.AspNetCore.Mvc;

namespace rdgtecnologyProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
