using Microsoft.AspNetCore.Mvc;
using WordCounterName;

namespace WordCounterName.Controllers
{
  public class HomeController : Controller
{
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}
}
