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
            return View(y1);
            
        }
    }
}
