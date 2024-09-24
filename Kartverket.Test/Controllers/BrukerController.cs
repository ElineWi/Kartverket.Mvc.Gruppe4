using Microsoft.AspNetCore.Mvc;

namespace Kartverket.Test.Controllers;

public class BrukerController : Controller
{
// GET
    public IActionResult Index()
    {
        return View();
    }
}