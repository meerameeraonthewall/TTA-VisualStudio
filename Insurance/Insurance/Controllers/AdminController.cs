using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            using (InsuranceQuotesEntities2 db = new InsuranceQuotesEntities2())
            {

                var entries = db.Entries.ToList();


                var table = new List<Entry>();
                foreach (var entry in entries)
                {
                    var e = new Entry();
                    e.Id = entry.Id;
                    e.FirstName = entry.FirstName;
                    e.LastName = entry.LastName;
                    e.EmailAddress = entry.EmailAddress;
                    e.DOB = entry.DOB;
                    e.CarYear = entry.CarYear;
                    e.CarMake = entry.CarMake;
                    e.CarModel = entry.CarModel;
                    e.DUI = entry.DUI;
                    e.Tickets = entry.Tickets;
                    e.Coverage = entry.Coverage;
                    e.Quote = entry.Quote;


                    table.Add(e);

                }


                return View(table);
            }

        
        }

    }
}
