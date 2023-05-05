using Microsoft.AspNetCore.Mvc;
using ViewDataRazorViewCoreMVC6.Models;

namespace ViewDataRazorViewCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("home")]
    [Route("/")]
    public IActionResult Index()
    {
      ViewData["appTitle"] = "Asp.Net Core Demo App";

      List<Person> people = new List<Person>()
      {
          new Person() { Name = "BlackCoder1", DateOfBirth = DateTime.Parse("1995-06-01"), PersonGender = Gender.Male},
          new Person() { Name = "BlackCoder2", DateOfBirth = DateTime.Parse("1995-07-01"), PersonGender = Gender.Female},
          new Person() { Name = "BlackCoder3", DateOfBirth = DateTime.Parse("1995-08-01"), PersonGender = Gender.Other}
      };
      ViewData["people"] = people;

      return View(); //Views/Home/Index.cshtml
    }
  }
}
