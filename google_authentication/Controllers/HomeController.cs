using google_authentication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GoogleAuthentication.Services;

namespace google_authentication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var clientID = "747302327814-g1jh6blerulbe0mmi8t85bc02ei9r0q1.apps.googleusercontent.com";
            var url = "https://localhost:7250/Login/GoogleLoginCallback";
            var responce = GoogleAuth.GetAuthUrl(clientID,url);
            ViewBag.response = responce;
            return View();
        }

    }
}