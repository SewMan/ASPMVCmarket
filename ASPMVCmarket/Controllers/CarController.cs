using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCmarket.Models;

namespace ASPMVCmarket.Controllers
{
    public class CarController : Controller
    {
        // GET: Car/Random
        public ActionResult Random()
        {
            var car = new Car() { Name = "Clio III" };
            return View(car);
        }
    }
}