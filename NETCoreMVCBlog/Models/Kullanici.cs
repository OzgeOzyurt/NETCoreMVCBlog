using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        [Display(Name = "Kullanıcı Adı")] 
        public string Ad { get; set; }
        [Display(Name = "Kullanıcı Soyadı")] 
        public string Soyad { get; set; }
        [Display(Name = "Kullanıcı Takma Adı")] 
        public string Nickname{ get; set; }
        public bool Aktif { get; set; }
    }
}
