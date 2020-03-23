using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Yetenek_Kartı.Models.Siniflar;

namespace Yetenek_Kartı.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {

            var degerler = c.Yeteneks.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenek y)
        {
            c.Yeteneks.Add(y);
            c.SaveChanges();

            return View();

        }
        public ActionResult YetenekSil(int id)
        {
            var deger = c.Yeteneks.Find(id);
            c.Yeteneks.Remove(deger);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var degerler = c.Yeteneks.Find(id);
            return View("YetenekGetir", degerler);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenek y)
        {
            var degerler = c.Yeteneks.Find(y.Id);
            degerler.Açiklama = y.Açiklama;
            degerler.deger = y.deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}