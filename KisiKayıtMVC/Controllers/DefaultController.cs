using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiKayıtMVC.Models.Entity;

namespace KisiKayıtMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        KisiselBlogDBEntities db= new KisiselBlogDBEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult KisiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KisiEkle(TBLKISILER p1)
        {
            db.TBLKISILER.Add(p1);
            db.SaveChanges();
            return View(); 
        }
    }
}