using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreGroup14GithubProject.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
