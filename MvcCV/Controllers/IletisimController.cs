using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Repositories;
using MvcCV.Models.Entity;

namespace MvcCV.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Tbl_Iletisim> repo = new GenericRepository<Tbl_Iletisim>(); 
        public ActionResult Index()
        {
            var iletisim = repo.List();
            return View(iletisim);
        }
    }
}