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

        public ActionResult CarDetails(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }

        [HttpPost]
        public ActionResult CarSave(Car car)
        {
            if (car.Id == 0)
            {
                _context.Cars.Add(car);
            }
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);
                carInDb.Name = car.Name;
                carInDb.Slogan1 = car.Slogan1;
                carInDb.Slogan2 = car.Slogan2;
                carInDb.Slogan3 = car.Slogan3;

                carInDb.ShortDescription = car.ShortDescription;
                carInDb.LongDescription = car.LongDescription;

                carInDb.ImagePath1 = car.ImagePath1;
                carInDb.ImagePath2 = car.ImagePath2;
                carInDb.ImagePath3 = car.ImagePath3;

                carInDb.DetBodyStyle = car.DetBodyStyle;
                carInDb.DetCurbWeight = car.DetCurbWeight;
                carInDb.DetHeight = car.DetHeight;
                carInDb.DetLength = car.DetLength;
                carInDb.DetMotor = car.DetMotor;
                carInDb.DetPrice = car.DetPrice;
                carInDb.DetProduction = car.DetProduction;
                carInDb.DetTransmission = car.DetTransmission;
                carInDb.DetWheelbase = car.DetWheelbase;
                carInDb.DetWidth = car.DetWidth;
            }
            
            _context.SaveChanges();
            return RedirectToAction("CarIndex", "Car");
        }

        public ActionResult CarEdit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View(car);
        }
    }
}