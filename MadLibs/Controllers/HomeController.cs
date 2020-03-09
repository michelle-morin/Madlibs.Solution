using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Options()
    {
      return View();
    }

    [Route("/epicodus")]
    public ActionResult Epicodus()
    {
      return View();
    }

    [Route("/epicodus-story")]
    public ActionResult EpicodusStory(string time, string name, string drink, string verb, string transportation, string noun, string alttransportation, string exclamation) 
    {
      EpicodusWords myEpicodusWords = new EpicodusWords();
      myEpicodusWords.Time = time;
      myEpicodusWords.Name = name;
      myEpicodusWords.Drink = drink;
      myEpicodusWords.Verb = verb;
      myEpicodusWords.Transportation = transportation;
      myEpicodusWords.Noun = noun;
      myEpicodusWords.AltTransportation = alttransportation;
      myEpicodusWords.Exclamation = exclamation;
      return View(myEpicodusWords); 
    }

    [Route("/trip")]
    public ActionResult Trip()
    {
      return View();
    }

    [Route("/trip-story")]
    public ActionResult TripStory()
    {

    }
  }
}