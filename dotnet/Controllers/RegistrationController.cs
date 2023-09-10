using dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
            => View();

        [HttpPost]
        public IActionResult CheckData(RegistrationModel registration)
            => ModelState.IsValid ? Redirect("/") : View("Index");
    }
}
