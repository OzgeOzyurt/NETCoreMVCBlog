using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        public int Id { get; set; }
        [Display(Name = "Gönderi Başlığı")] 
        public string Konu { get; set;  }
        [Display(Name = "Gönderi İçeriği")] 
        public string Icerik { get; set; }
        [Display(Name = "Gönderi Tarihi")] 
        public DateTime Tarih { get; set; }
        public int YazarId { get; set; }
    }
}
