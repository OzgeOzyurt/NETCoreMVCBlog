using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        [Display(Name = "Yorum İçeriği")]
        public string Icerik { get; set; }
        [Display(Name = "Yorum Tarihi")]
        public DateTime Tarih { get; set; }
        public int GonderiId { get; set; }
        public int YazarId {get; set; }
    }
}
