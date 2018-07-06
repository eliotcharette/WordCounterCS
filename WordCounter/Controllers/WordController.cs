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
  [HttpPost("/word")]
  public ActionResult Create(string word, int times)
  {
    WordCounterScore newWordCounterScore = new WordCounterScore(word, times);
    newWordCounterScore.Save();
    return View("word", WordCounterScore.GetAll());
  }
}
}
