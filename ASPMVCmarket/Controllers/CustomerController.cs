using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCmarket.Models;

namespace ASPMVCmarket.Controllers
{
    public class CustomerController : Controller
    {
        //GET: http://localhost:62273/Customer/CustomerIndex
        public ViewResult CustomerIndex()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        //GET: http://localhost:62273/Customer/CustomerDetails
        public ActionResult CustomerDetails(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name = "Seweryn Łaśko" },
                new Customer { Id = 2, Name = "Marcin Burek" }
            };
        }
    }
}