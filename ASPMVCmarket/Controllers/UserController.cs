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

        //GET: http://localhost:62273/User/UserDetails
        public ActionResult UserDetails(string id)
        {
            var context = new ApplicationDbContext();
            var identityUser = context.Users.SingleOrDefault(u => u.Id == id);

            if (identityUser == null)
            {
                return HttpNotFound();
            }

            return View(identityUser);
        }

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

        //Save new customer to the database
        [HttpPost] //<- can only be called by HttpPost not HttpGet
        [ValidateAntiForgeryToken] //<- Token for Cross-Site Request Forgery (CSRF) prevention
        public ActionResult UserSave(ApplicationUser user)
        {
            // Validation
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }

            var context = new ApplicationDbContext();
            var identityUserInDb = context.Users.Single(u => u.Id == user.Id);

            identityUserInDb.Name = user.Name;
            identityUserInDb.Surname = user.Surname;
            identityUserInDb.Email = user.Email;

            identityUserInDb.Email = user.Email;
            identityUserInDb.BirthDate = user.BirthDate;
            identityUserInDb.PhoneNumber = user.PhoneNumber;

            identityUserInDb.Street = user.Street;
            identityUserInDb.City = user.City;
            identityUserInDb.CityCode = user.CityCode;
            
            context.SaveChanges();

            return RedirectToAction("UserIndex", "User");
        }

        //Edit customer from the database
        public ActionResult UserEdit(string id)
        {
            var context = new ApplicationDbContext();
            var user = context.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                return HttpNotFound();

            return View("UserEdit", user);
        }
    }
}