using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            Kullanici k1 = new Kullanici { Id = 1, Ad = "Özge", Soyad = "Özyurt", Nickname = "ozgeozyurt00", Aktif = true };
            Kullanici k2 = new Kullanici { Id = 2, Ad = "Cem", Soyad = "Badem", Nickname = "cemolokko", Aktif = true };
            Kullanici k3 = new Kullanici { Id = 3, Ad = "Beste", Soyad = "Pars", Nickname = "best22", Aktif = true };

            List<Kullanici> kullaniciListe = new List<Kullanici>();
            kullaniciListe.Add(k1);
            kullaniciListe.Add(k2);
            kullaniciListe.Add(k3);

            return View(kullaniciListe);
        }
    }
}
