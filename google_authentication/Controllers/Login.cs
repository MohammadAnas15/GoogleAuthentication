using Microsoft.AspNetCore.Mvc;
using GoogleAuthentication.Services;

namespace google_authentication.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GoogleLoginCallback(string code) 
        {
            var clientID = "747302327814-g1jh6blerulbe0mmi8t85bc02ei9r0q1.apps.googleusercontent.com";
            var url = "https://localhost:7250/Login/GoogleLoginCallback";
            var clientSecrets = "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";
            var token = await GoogleAuth.GetAuthAccessToken(code,clientID,clientSecrets,url);
            var userprofile = await GoogleAuth.GetProfileResponseAsync(token.AccessToken);

            ViewBag.shj = userprofile;

            return View();
        
        }


    }
}
