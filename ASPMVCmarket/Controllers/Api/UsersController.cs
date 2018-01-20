using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPMVCmarket.Controllers.Api
{
    public class UsersController : ApiController
    {
        // GET /api/users
        public IEnumerable<IdentityUser>GetUsers()
        {
            var context = new IdentityDbContext();
            var users = context.Users.ToList();
            return users;
        }

        // GET /api/users/1
        public IdentityUser GetUser(string id)
        {
            var context = new IdentityDbContext();
            var identityUser = context.Users.SingleOrDefault(u => u.Id == id);

            if (identityUser == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return identityUser;
        }

        // POST /api/users
        [HttpPost]
        public IdentityUser CreateUser(IdentityUser identityUser)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var context = new IdentityDbContext();
            context.Users.Add(identityUser);
            context.SaveChanges();

            return identityUser;
        }

        // PUT /api/users/1
        [HttpPut]
        public void UpdateUser(string id, IdentityUser identityUser)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var context = new IdentityDbContext();
            var identityUserInDb = context.Users.SingleOrDefault(u => u.Id == id);

            if (identityUserInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //identityUserInDb.Id = identityUser.Id;
            identityUserInDb.Email = identityUser.Email;
            identityUserInDb.EmailConfirmed = identityUser.EmailConfirmed;
            //identityUserInDb.PasswordHash = identityUser.PasswordHash;
            //identityUserInDb.SecurityStamp = identityUser.SecurityStamp;
            identityUserInDb.PhoneNumber = identityUser.PhoneNumber;
            identityUserInDb.PhoneNumberConfirmed = identityUser.PhoneNumberConfirmed;
            //identityUserInDb.TwoFactorEnabled = identityUser.TwoFactorEnabled;
            //identityUserInDb.LockoutEndDateUtc = identityUser.LockoutEndDateUtc;
            //identityUserInDb.LockoutEnabled = identityUser.LockoutEnabled;
            //identityUserInDb.AccessFailedCount = identityUser.AccessFailedCount;
            identityUserInDb.UserName = identityUser.UserName;

            context.SaveChanges();
        }

        // DELETE /api/users/1
        [HttpDelete]
        public void DeleteUser(string id)
        {
            var context = new IdentityDbContext();
            var identityUserInDb = context.Users.SingleOrDefault(u => u.Id == id);

            if (identityUserInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            context.Users.Remove(identityUserInDb);
            context.SaveChanges();
        }
    }
}
