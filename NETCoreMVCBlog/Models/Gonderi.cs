namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        public int Id { get; set; }
        public string Konu { get; set;  }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public int YazarId { get; set; }
    }
}
