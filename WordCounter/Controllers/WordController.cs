using Microsoft.AspNetCore.Mvc;
using WordCounterName;

namespace WordCounterName.Controllers
{
  public class WordController : Controller
{
  [HttpGet("/input")]
  public ActionResult Form()
  {
    return View();
  }
  // [HttpPost("/word")]
  // public ActionResult Create()
  // WordCounterScore newWord = new WordCounterScore();
  //   newWord.FindWord();
}
}
