using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class PolicyController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Policy
        public ActionResult Index()
        {
            return View(db.Policies.ToList());
        }

        // VIEW MODEL FOR ADMINS
        public ActionResult AdminVm()
        {
            using (db)
            {
                var persons = db.Policies.ToList();
                var Admin = new List<AdminVm>();
                foreach (var AdminVm in persons)
                {
                    var av = new AdminVm
                    {
                        Id = AdminVm.Id,
                        FirstName = AdminVm.FirstName,
                        LastName = AdminVm.LastName,
                        EmailAddress = AdminVm.EmailAddress,
                        Quote = AdminVm.Quote
                    };
                    Admin.Add(av);

                }
                return View(Admin);

            }
        }

        // GET: Policy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        // GET: Policy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Policy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,Tickets,Dui,Coverage,Quote")] Policy policy)
        {
            if (string.IsNullOrEmpty(policy.FirstName) || string.IsNullOrEmpty(policy.LastName) || string.IsNullOrEmpty(policy.EmailAddress) || string.IsNullOrEmpty(policy.DateOfBirth.ToString()) ||
               string.IsNullOrEmpty(policy.CarYear.ToString()) || string.IsNullOrEmpty(policy.CarMake) || string.IsNullOrEmpty(policy.CarModel) || string.IsNullOrEmpty(policy.Tickets.ToString()))
            {
                return View("~/Views/Shared/Error.cshtml");

            }
            else
            {
                policy.Quote = 50;
                //var quote = policy.Quote;

                //DOB
                int age = DateTime.Now.Year - policy.DateOfBirth.Year;
                if (age < 18)
                {
                    policy.Quote += 100.00m;
                }
                else if (age >= 18 && (age < 25 || age > 100))
                {
                    policy.Quote += 25.00m;
                }

                //Car Year
                int year = policy.CarYear;
                if (year < 2000 || year > 2015)
                {
                    policy.Quote += 25.00m;
                }

                //Car Make
                string make = policy.CarMake.ToLower();
                string model = policy.CarModel.ToLower();
                if (make == "porsche")
                {
                    policy.Quote = policy.Quote + 25.00m;
                    if (model == "911 Carrera")
                    {
                        policy.Quote += 25.00m;
                    }
                }

                //Tickets
                int tickets = policy.Tickets;
                policy.Quote = policy.Quote + (10 * tickets);

                //DUIs
                if (policy.Dui == true)
                {
                    policy.Quote = policy.Quote + (policy.Quote * .25m);
                }

                // Coverage 
                if (policy.Coverage == true)
                {
                    policy.Quote = policy.Quote + (policy.Quote * .50m);
                }

                db.Policies.Add(policy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //return View(policy);
        }

        // GET: Policy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        // POST: Policy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,Tickets,Dui,Coverage,Quote")] Policy policy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policy);
        }

        // GET: Policy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        // POST: Policy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Policy policy = db.Policies.Find(id);
            db.Policies.Remove(policy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
