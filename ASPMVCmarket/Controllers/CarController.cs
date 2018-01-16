using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCmarket.Models;

namespace ASPMVCmarket.Controllers
{
    [AllowAnonymous]
    public class CarController : Controller
    {
        //Baza danych -> _context
        private ApplicationDbContext _context;

        public CarController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: http://localhost:62273/Car/CarIndex
        //ActionResult Subtypes -> ViewResult - Renders a specifed view to the response stream
        public ViewResult CarIndex()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }

        // GET: http://localhost:62273/Car/CarRandom
        // ActionResult is an abstract class that can have several subtypes.
        public ActionResult CarRandom()
        {
            var car = new Car() { Name = "Clio III" };
            return View(car);
        }

        public ActionResult CarDetails(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }
    }
}