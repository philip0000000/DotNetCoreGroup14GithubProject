using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace DotNetCoreGroup14GithubProject.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {

            Console.WriteLine("Hello");
            return View();
        }
    }
}
