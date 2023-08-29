using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using ReGoAuthentication.Data;
using ReGoAuthentication.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;

namespace ReGoAuthentication.Controllers
{
    [Authorize]
    public class JobSeekerController : Controller
    {
        private ReGoDBContext cow;

        public JobSeekerController()
        {
            cow = new ReGoDBContext();
        }

        // GET: JobSeeker
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfile(Users users)
        {
            Users model = new Users();

            users.Username = User.Identity.Name;
            users.Email = User.Identity.Name;
            users.Isactive = 1;

            cow.Users.Add(users); 
            cow.SaveChanges();

            return RedirectToAction("ViewProfile");
        }

        public ActionResult ViewProfile()
        {
            string username = User.Identity.Name;
            Users userProfile = cow.Users.FirstOrDefault(u => u.Username == username);

            if (userProfile != null)
            {
                return View(userProfile);
            }

            // Handle case where user profile is not found
            return RedirectToAction("CreateProfile");
        }

        public ActionResult EditProfile()
        {
            string username = User.Identity.Name;
            Users userProfile = cow.Users.FirstOrDefault(u => u.Username == username);

            if (userProfile != null)
            {
                return View(userProfile);
            }

            // Handle case where user profile is not found
            return RedirectToAction("CreateProfile");
        }

        [HttpPost]
        public ActionResult EditProfile(Users updatedProfile)
        {
            string username = User.Identity.Name;
            Users userProfile = cow.Users.FirstOrDefault(u => u.Username == username);

            if (userProfile != null)
            {
                userProfile.FirstName = updatedProfile.FirstName;
                userProfile.LastName = updatedProfile.LastName;
                userProfile.ProfilePicture = updatedProfile.ProfilePicture;
                userProfile.Headline = updatedProfile.Headline;
                userProfile.Summary = updatedProfile.Summary;
                userProfile.Location = updatedProfile.Location;
                userProfile.CellNumber = updatedProfile.CellNumber;
                userProfile.AltCellNumber = updatedProfile.AltCellNumber;

                cow.SaveChanges();
                return RedirectToAction("ViewProfile");
            }

            return RedirectToAction("CreateProfile");
        }

    }
}
