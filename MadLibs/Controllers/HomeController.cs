using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string time, string name, string drink, string verb, string transportation, string noun, string alttransportation, string exclamation) 
    {
      StoryWords myStoryWords = new StoryWords();
      myStoryWords.Time = time;
      myStoryWords.Name = name;
      myStoryWords.Drink = drink;
      myStoryWords.Verb = verb;
      myStoryWords.Transportation = transportation;
      myStoryWords.Noun = noun;
      myStoryWords.AltTransportation = alttransportation;
      myStoryWords.Exclamation = exclamation;
      return View(myStoryWords); 
    }
  }
}