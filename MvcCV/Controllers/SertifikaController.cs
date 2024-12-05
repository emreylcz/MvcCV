using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<Tbl_Sertifikalarim> repo = new GenericRepository<Tbl_Sertifikalarim>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }

        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;  // id bağlantısı olmayan sayfaya id getirmek için kullanılır
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaGetir(Tbl_Sertifikalarim t)
        {
            var s = repo.Find(x => x.ID == t.ID);
            s.Tarih = t.Tarih;
            s.Aciklama = t.Aciklama;
            repo.TUpdate(s);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult SertifikaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SertifikaEkle(Tbl_Sertifikalarim t)
        {
            repo.TAdd(t);
            return RedirectToAction("index");
        }

        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            repo.TDelete(sertifika);
            return RedirectToAction("index");
        }
    }
}