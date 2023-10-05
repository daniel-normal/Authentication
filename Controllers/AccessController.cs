using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers;

public class AccessController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}