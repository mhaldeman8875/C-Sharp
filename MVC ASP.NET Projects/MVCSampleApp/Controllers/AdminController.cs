using MVCSampleApp.Models;
using MVCSampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // lambda expression to sort out "Unsubscribed" people:
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                // Uses SQL like statement from LINQ to sort list to only display active subscribers:
                ///var signups = (from c in db.SignUps
                ///               where c.Removed == null
                ///               select c).ToList();


                var signupVms = new List<SignUpVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignUpVm
                    {
                        Id = signup.Id,
                        FirstName = signup.FirstName,
                        LastName = signup.LastName,
                        EmailAddress = signup.EmailAddress
                    };
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}