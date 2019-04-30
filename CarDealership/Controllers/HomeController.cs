using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/car/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/car")]
    public ActionResult Create(string makeModel, int price, int miles, string message)
    {
      Car myCar = new Car(makeModel, price, miles, message);
      return RedirectToAction("Index");
    }

  }
}
