using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class YorumController : Controller
    {
        public IActionResult Index()
        {
            Yorum y1 = new Yorum
            {
                Id = 1,
                Icerik = "ChatGPT' den mi aldınız bu metni?",
                Tarih = new DateTime(2023, 07, 15),
                GonderiId = 1,
                YazarId = 3,
            };
            Yorum y2 = new Yorum
            {
                Id = 2,
                Icerik = "Ellerinize sağlık, çok faydalı olmuş.",
                Tarih = new DateTime(2023, 07, 16),
                GonderiId = 1,
                YazarId = 2,
            };
            
            List<Yorum> yorumListe = new List<Yorum>();
            yorumListe.Add(y1);
            yorumListe.Add(y2);

            return View(yorumListe);
            
            
        }
    }
}
