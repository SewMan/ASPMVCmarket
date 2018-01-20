using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCmarket.Models;
using ASPMVCmarket.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPMVCmarket.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {

        //GET: http://localhost:62273/User/UserIndex
        public ViewResult UserIndex()
        {
            return View();
        }

        ////GET: http://localhost:62273/User/UserDetails
        //public ActionResult UserDetails(string id)
        //{
        //    var context = new IdentityDbContext();
        //    var identityUser = context.Users.SingleOrDefault(u => u.Id == id);

        //    if (identityUser == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(identityUser);
        //}

        ////GET: http://localhost:62273/Customer/New
        //public ActionResult New()
        //{
        //    var membershipTypes = _context.MembershipTypes.ToList();
        //    var viewModel = new CustomerFormViewModel()
        //    {
        //        Customer = new Customer(),
        //        MembershipTypes = membershipTypes
        //    };

        //    return View("CustomerForm", viewModel);
        //}

        ////Save new customer to the database
        //[HttpPost] //<- can only be called by HttpPost not HttpGet
        //[ValidateAntiForgeryToken] //<- Token for Cross-Site Request Forgery (CSRF) prevention
        //public ActionResult Save(Customer customer)
        //{
        //    // Validation
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new CustomerFormViewModel
        //        {
        //            Customer = customer,
        //            MembershipTypes = _context.MembershipTypes.ToList()
        //        };

        //        return View("CustomerForm", viewModel);
        //    }

        //    if (customer.Id == 0)
        //        _context.Customers.Add(customer);
        //    else
        //    {
        //        var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

        //        customerInDb.Name = customer.Name;
        //        customerInDb.BirthTime = customer.BirthTime;
        //        customerInDb.MembershipTypeId = customer.MembershipTypeId;
        //        customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
        //    }
            

        //    _context.SaveChanges();

        //    return RedirectToAction("CustomerIndex", "Customer");
        //}

        ////Edit customer from the database
        //public ActionResult Edit(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

        //    if (customer == null)
        //        return HttpNotFound();

        //    var viewModel = new CustomerFormViewModel
        //    {
        //        Customer = customer,
        //        MembershipTypes = _context.MembershipTypes.ToList()
        //    };

        //    return View("CustomerForm", viewModel);
        //}
    }
}