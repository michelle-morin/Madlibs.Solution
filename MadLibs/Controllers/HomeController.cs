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
    public ActionResult TripStory(string adjective, string person1, string person2, string store, string foodItem1, string foodItem2, string exclamation, string noun1, string noun2, string yell, string verb, string destination)
    {
      WeekendWords myWeekendWords = new WeekendWords();
      myWeekendWords.Adjective = adjective;
      myWeekendWords.Person1 = person1;
      myWeekendWords.Person2 = person2;
      myWeekendWords.Store = store;
      myWeekendWords.FoodItem1 = foodItem1;
      myWeekendWords.FoodItem2 = foodItem2;
      myWeekendWords.Exclamation = exclamation;
      myWeekendWords.Noun1 = noun1;
      myWeekendWords.Noun2 = noun2;
      myWeekendWords.Yell = yell;
      myWeekendWords.Verb = verb;
      myWeekendWords.Destination = destination;
      return View(myWeekendWords);
    }
  }
}