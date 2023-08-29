using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ReGoAuthentication.Models;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Net.Mail;

namespace ReGoAuthentication.Controllers
{
    public class AccountsController : Controller
    {
        ReGoSignInEntities entity = new ReGoSignInEntities();

        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel credentials)
        {
            bool userExist = entity.Users.Any(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
            User u = entity.Users.FirstOrDefault(x => x.Email == credentials.Email && x.Passcode == credentials.Password);

            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Incorrect Email or Password");

            return View();
        }

        [HttpPost]
        public ActionResult Signup(User userInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(userInfo);
            }

            //Check if the username already exists
            if (UsernameExists(userInfo.UserName))
            {
                ModelState.AddModelError("UserName", "Username already exists.");
                return View(userInfo);
            }

            //Check if the email already exists
            if (EmailExists(userInfo.Email))
            {
                ModelState.AddModelError("Email", "Email already exists.");
                return View(userInfo);
            }

            entity.Users.Add(userInfo);
            entity.SaveChanges();

            SendConfirmationEmail(userInfo.Email);

            return RedirectToAction("Login");
        }

        private void SendConfirmationEmail(string email)
        {
            // Configure email client settings
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "********";
            string smtpPassword = "******";

            using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
            {
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                client.EnableSsl = true;

                // Create and send email
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("******");
                mail.To.Add(email);
                mail.Subject = "Rego - Confirmation Email";
                mail.Body = "Thank you for signing up! Your account has been created.";

                client.Send(mail);
            }
        }


        private bool UsernameExists(string username)
        {
            return entity.Users.Any(u => u.UserName == username);
        }

        private bool EmailExists(string email)
        {

            return entity.Users.Any(u => u.Email == email);
        }

        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}