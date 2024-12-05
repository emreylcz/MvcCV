using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var SosyalMedya = repo.List();
            return View(SosyalMedya);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            return View(hesap);
        }

        [HttpPost]
        public ActionResult SayfaGetir(TblSosyalMedya p)
        {
            var h = repo.Find(x => x.ID == p.ID);
            h.Ad = p.Ad;
            h.Link = p.Link;
            h.icon = p.icon;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var h = repo.Find(x => x.ID == id);
            h.Durum = false;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }

        public ActionResult AktifEt(int id)
        {
            var h = repo.Find(x => x.ID == id);
            h.Durum = true;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }
    }
}