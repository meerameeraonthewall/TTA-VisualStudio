using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string firstName, string lastName, string email, int birthyr, int birthmonth, int birthday, int caryr, string carmake, string carmodel, string dui, int tickets, string coverage)
        {
           
            using (InsuranceQuotesEntities2 db = new InsuranceQuotesEntities2())
            {
                var q = new Entry();
                q.FirstName = firstName;
                q.LastName = lastName;
                q.EmailAddress = email;

                DateTime dob = new DateTime(birthyr, birthmonth, birthday, 0, 0, 0);

                q.DOB = dob.Date;
                q.CarYear = caryr;
                q.CarMake = carmake;
                q.CarModel = carmodel;

                if (dui == "true") q.DUI = true;
                else q.DUI = false;

                q.Tickets = tickets;

                if (coverage == "true") q.Coverage = true;
                else q.Coverage = false;


                TimeSpan twentyfive = new TimeSpan(9125, 0, 0, 0);
                TimeSpan eighteen = new TimeSpan(6570, 0, 0, 0);
                TimeSpan hundred = new TimeSpan(36500, 0, 0, 0);

                decimal quote = 50;

                if (DateTime.Now.Subtract(dob) < twentyfive)
                {
                    quote += 25;
                    if (DateTime.Now.Subtract(dob) < eighteen) quote += 75;
                }

                else if (DateTime.Now.Subtract(dob) > hundred) quote += 25;

                if (caryr < 2000 || caryr > 2015) quote += 25;
                if (carmake == "Porsche")
                {
                    quote += 25;
                    if (carmodel == "911 Carrera") quote += 25;
                }

                quote += 10 * tickets;
                if (dui=="true") quote = (quote * 5/4);
                if (coverage == "true") quote = (quote * 3/2);

                q.Quote = quote;
                ViewBag.Quote= quote;

                db.Entries.Add(q);
                db.SaveChanges();

            }

            return View("Success");
            }
        }


    }
