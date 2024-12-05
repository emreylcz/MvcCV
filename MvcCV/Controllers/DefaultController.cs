using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;

namespace MvcCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkımda.ToList();
            return View(degerler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.ToList();
            return PartialView(sosyalmedya);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.Tbl_Egitimlerim.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.Tbl_Yeteneklerim.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.Tbl_Hobilerim.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalarim()
        {
            var sertifikalar = db.Tbl_Sertifikalarim.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet] // sayfa yüklendiği anda çalışacak olan yer
        public PartialViewResult iletisim()
        {
            return PartialView();
        }

        [HttpPost] // button tıklandığında çalışması için
        public PartialViewResult iletisim(Tbl_Iletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_Iletisim.Add(t); //veri ekle
            db.SaveChanges(); //veri kaydet
            return PartialView();
        }
    }
}