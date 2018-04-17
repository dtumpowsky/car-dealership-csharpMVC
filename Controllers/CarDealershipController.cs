using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create()
        {
          Car newCar = new Car(Request.Form["new-model"], int.Parse(Request.Form["new-mile"]), int.Parse(Request.Form["new-price"]), Request.Form["new-color"]);
          newCar.Save();

          List<Car> allCars = Car.GetAll();
          return View("Index", allCars);
        }

        [HttpPost("/cars/delete")]
        public ActionResult DeleteAll()
        {
            Car.ClearAll();
            return View();
        }
    }
}
