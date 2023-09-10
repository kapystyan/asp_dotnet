using dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            => View();
    }
}