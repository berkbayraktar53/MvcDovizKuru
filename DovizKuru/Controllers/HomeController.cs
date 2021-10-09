using DovizKuru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DovizKuru.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DovizKuruIslemleri islemler = new DovizKuruIslemleri();
            IEnumerable<DovizKuruModel> liste = islemler.DovizKurlari();
            return View(liste);
        }
    }
}