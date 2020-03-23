using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Yetenek_Kartı.Models.Siniflar;

namespace Yetenek_Kartı.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();

            var degerler = c.Yeteneks.ToList();

            return View(degerler);
        }
    }
}