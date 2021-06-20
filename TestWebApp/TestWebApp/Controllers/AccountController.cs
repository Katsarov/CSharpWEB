

using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            this.Response.Cookies.Append("Authentication", "Kalin");

            return View();
        }
    }
}
