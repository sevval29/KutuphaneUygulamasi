using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Models
{
    public class Kitap
    {

        public Kitap()
        {
            KutuphaneDurumu = true; // Yeni kitap eklendiğinde varsayılan değer olarak KutuphaneDurumu alanını true olarak ayarlanır
            OduncAlanAdi = ""; //Yeni kitap eklendiğinde varsayılan değer olarak OduncAlanAdi alanını "" ayarlar.
        }

        [Key]
        public int ID { get; set; }

      
        public string KitapAd { get; set; }

    
        public string Yazar { get; set; }

       
        public string ResimUrl { get; set; }
        public bool KutuphaneDurumu { get; set; }

        public string OduncAlanAdi { get; set; }
        public DateTime? GeriGetirmeTarihi { get; set; }
    }
}
