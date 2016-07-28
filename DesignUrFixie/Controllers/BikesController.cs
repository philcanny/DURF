using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DesignUrFixie.Models;
using Stripe;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;


namespace DesignUrFixie.Controllers
{
    [Authorize]
    public class BikesController : Controller 
    {
        
        private MyDbContext db = new MyDbContext();   //create an instance of the DataContext class in our DB
       // private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bikes
        //[Authorize]
        public ActionResult Index()
        {
            return View(db.Bikes.ToList());
        }

        // GET: Bikes/Details/5
        //[Authorize]
        public ActionResult Details(int? id)
        {
            // Phil making changes to create admin access
            var userId = User.Identity.GetUserId();
            //var userAccount = db.Bikes.Where(id == userId).First();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }

            return View(bike);
                   
    }



        // GET: Bikes/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bikes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BikeId,CustomerName,FrameColour,SaddleColour,HandlebarColour,WheelColour")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Bikes.Add(bike);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        // GET: Bikes/Edit/5
        //[Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        // POST: Bikes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BikeId,CustomerName,FrameColour,SaddleColour,HandlebarColour,WheelColour")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bike).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bike);
        }

        // GET: Bikes/Delete/5
        //[Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        // POST: Bikes/Delete/5
        //[Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bike bike = db.Bikes.Find(id);
            db.Bikes.Remove(bike);
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



        // STRIPE CODE //

        public ActionResult Charge()
        {

            ViewBag.Message = "Charge what you like";

            return View(new StripeChargeModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Charge(StripeChargeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var chargeId = await ProcessPayment(model);
            return RedirectToAction("Result", "Home"); ;
        }


        private async Task<string> ProcessPayment(StripeChargeModel model)
        {
            return await Task.Run(() =>
            {
                var myCharge = new StripeChargeCreateOptions
                {
                    // convert the amount of €525.00 to pennies i.e. 52500  removed int from line below and added 525
                    Amount = (int)(model.Amount * 100),
                    Currency = "eur",
                    Description = "Description for test charge",
                    Source = new StripeSourceOptions
                    {
                        TokenId = model.Token
                    }
                };

                var chargeService = new StripeChargeService("sk_test_3RiGWe2dnDwGiXGBS2F6iQ3m");
                var stripeCharge = chargeService.Create(myCharge);

                return stripeCharge.Id;
            });
        }


    }
}
