using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
// make name of controller plural ex: 'ItemsController' even though model is called 'Item'

namespace PlacesYouveBeen.Controllers
{
    public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string date, string entry)
    {
      Place myPlace = new Place(cityName, date, entry);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/new")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return RedirectToAction("Index");
    }
  }
}