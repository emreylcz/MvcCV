using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        GenericRepository<Tbl_Egitimlerim> repo = new GenericRepository<Tbl_Egitimlerim>();

        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EgitimEkle(Tbl_Egitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("index");
        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TDelete(egitim);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }

        [HttpPost]
        public ActionResult EgitimDuzenle(Tbl_Egitimlerim t)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EgitimDuzenle");
            }
            var e = repo.Find(x => x.ID == t.ID);
            e.Baslik = t.Baslik;
            e.AltBaslik1 = t.AltBaslik1;
            e.AltBaslik2 = t.AltBaslik2;
            e.Tarih = t.Tarih;
            e.GNO = t.GNO;
            repo.TUpdate(e);
            return RedirectToAction("index");
        }
    }
}