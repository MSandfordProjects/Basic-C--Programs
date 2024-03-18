using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteCalculation(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteCalculation(insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        
        private int AgeTotal(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            //take the date given, check to see if the date is after age, if true they
            //haven't had a birthday yet this year, subtract 1. if false leave.
            if (dateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;
            return age;
        }

        private decimal QuoteCalculation(Insuree insuree)
        {
            //starting total
            decimal monthlyTotal = 50;
            //get their age
            int age = AgeTotal(insuree.DateOfBirth);
            //user is 18 or under
            if (age <= 18)
            {
                monthlyTotal += 100;
            }
            //user is from 19 to 25
            else if (age >= 19 && age <= 25)
            {
                monthlyTotal += 50;
            }
            //user is 26 or older
            else
            {
                monthlyTotal += 25;
            }

            int carYear = insuree.CarYear;
            //car's year is before 2000
            if (carYear < 2000)
            {
                monthlyTotal += 25;
            }
            //car's year is after 2015
            else if (carYear > 2015)
            {
                monthlyTotal += 25;
            }

            //car's Make is a Porsche
            if (insuree.CarMake == "Porsche")
            {
                monthlyTotal += 25;
                //car's Make is a Porsche and its model is a 911 Carrera
                if (insuree.CarModel == "911 Carrera")
                {
                    monthlyTotal += 25;
                }
            }

            //Add $10 to the monthly total for every speeding ticket the user has
            monthlyTotal += 10 * insuree.SpeedingTickets;

            //If the user has ever had a DUI, add 25% to the total.
            if (insuree.DUI)
            {
                monthlyTotal *= 1.25m;
            }

            //If it's full coverage, add 50% to the total.
            if (insuree.CoverageType == true)
            {
                monthlyTotal *= 1.5m;
            }

            return monthlyTotal;

        }

      
    }
}
