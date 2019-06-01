using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganicFood.Models.Entity;

namespace OrganicFood.Controllers
{
    public class HomeController : Controller
    {
        TarimDatabaseEntities db = new TarimDatabaseEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLUrunler.ToList();

            return View(degerler);
        }

        public ActionResult About()
        { 

            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {  
            return View();
        }
    }
}