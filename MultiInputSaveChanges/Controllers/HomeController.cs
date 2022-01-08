using Microsoft.AspNetCore.Mvc;
using MultiInputSaveChanges.Models;
using System.Collections.Generic;

namespace MultiInputSaveChanges.Controllers
{
    public class HomeController : Controller
    {
        private readonly MultiInputContext _multiInputContext;

        public HomeController(MultiInputContext multiInputContext)
        {
            _multiInputContext = multiInputContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Egitim egitim)
        {

             _multiInputContext.Egitims.Add(egitim);
            _multiInputContext.SaveChanges();

            List<Grup> grupList = new List<Grup>();

            for (var i = 0; i < egitim.GrupSayisi.Length; i++)
            {
                Grup grup = new Grup
                {
                    Adet = egitim.GrupNo[i],
                    Sayi = egitim.GrupSayisi[i],
                    Tarih = egitim.GrupTarihi[i],
                    EgitimId = egitim.Id
                };
                _multiInputContext.Grups.Add(grup);
               
            }
            _multiInputContext.SaveChanges();
            return View(egitim);

        }
    }
}
