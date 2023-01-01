using Microsoft.AspNetCore.Mvc;

namespace LibraryAppNi.Server.Views.Home;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}