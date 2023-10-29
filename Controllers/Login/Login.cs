using Microsoft.AspNetCore.Mvc;

namespace PDA.Controllers.Login
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
