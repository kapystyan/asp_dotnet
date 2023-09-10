using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index() 
            => View();
    }
}
