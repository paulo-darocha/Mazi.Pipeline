using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mazi.Pipeline.WebUi.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
   public IActionResult Index()
   {
      return View();
   }
}
