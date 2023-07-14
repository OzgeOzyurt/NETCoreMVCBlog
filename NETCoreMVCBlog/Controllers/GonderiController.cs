using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class GonderiController : Controller
    {
        public IActionResult Index()
        {
            Gonderi g1 = new Gonderi
            {
                Id= 1,
                Konu = "MVC Nedir?",
                Icerik = "MVC (Model-View-Controller), yazılım geliştirme sürecinde kullanılan bir tasarım desenidir. Bu desen, uygulamanın farklı katmanlarını ve sorumluluklarını ayrıştırarak daha düzenli, esnek ve bakımı kolay bir yapı oluşturmayı hedefler.\r\n\r\nMVC deseni, aşağıdaki üç ana bileşeni içerir:\r\n\r\nModel (Model): Uygulamanın veri yapısını ve iş mantığını temsil eder. Model, verileri depolar, işlemleri gerçekleştirir ve uygulama durumunu yönetir. Örneğin, bir kullanıcının bilgilerini depolayan bir \"Kullanıcı\" modeli olabilir.\r\n\r\nGörünüm (View): Kullanıcı arayüzünü temsil eder. Görünüm, kullanıcıya verilerin nasıl gösterileceğini belirler. Kullanıcı arayüzündeki HTML, CSS ve UI bileşenlerini içerir. Görünüm, genellikle modelin verilerini temsil eden bir şablon kullanarak verileri görüntüler.\r\n\r\nDenetleyici (Controller): Kullanıcının etkileşimlerini yönetir ve uygulama akışını kontrol eder. Denetleyici, kullanıcının taleplerini karşılar, ilgili iş mantığını yürütür, modeli günceller ve uygun görünümü kullanıcıya sunar. Kullanıcının bir formu göndermesi, bir sayfayı görüntülemesi gibi olaylar denetleyici tarafından işlenir.\r\n\r\nMVC deseni, bir uygulamanın bileşenlerini birbirinden bağımsız tutarak modülerlik ve yeniden kullanılabilirlik sağlar. Bu, kodun daha kolay test edilebilir ve bakımı daha kolay hale gelir. Ayrıca, ekip çalışmasını ve paralel geliştirmeyi destekler.\r\n\r\nASP.NET MVC veya ASP.NET Core MVC gibi web uygulama çerçeveleri, MVC desenini web uygulamaları için uygulama sağlar. Bu çerçeveler, HTTP isteklerini denetleyiciler aracılığıyla karşılar, iş mantığını modelde gerçekleştirir ve sonuçları görünümlere aktarır. Böylece, veri işleme, sunum ve kullanıcı etkileşimi ayrı bileşenlerde yapılandırılabilir ve uygulama daha modüler bir şekilde geliştirilebilir.",
                Tarih = new DateTime(2023, 07, 14),
                YazarId = 1,
            };
            return View(g1);
        }
    }
}
