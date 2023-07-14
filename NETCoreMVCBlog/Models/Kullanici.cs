namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        public int Id { get; set; } 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Nickname{ get; set; }
        public bool Aktif { get; set; }
    }
}
