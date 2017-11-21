﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCmarket.Models;

namespace ASPMVCmarket.Controllers
{
    public class CarController : Controller
    {
        // GET: http://localhost:62273/Car/CarIndex
        //ActionResult Subtypes -> ViewResult - Renders a specifed view to the response stream
        public ViewResult CarIndex()
        {
            var cars = GetCars();
            return View(cars);
        }

        // GET: http://localhost:62273/Car/CarRandom
        // ActionResult is an abstract class that can have several subtypes.
        public ActionResult CarRandom()
        {
            var car = new Car() { Name = "Clio III" };
            return View(car);
        }

        private IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car() { Id = 1, Name= "Model S" },
                new Car() { Id = 2, Name = "Model M3"}
            };
        }
    }
}