using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Models.Models
{

    [Table("tb_Kitap")]
    public class Kitap
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Kitap_Id { get; set; }

        public string KitapAdi { get; set; }


        public double Fiyat { get; set; }

        public string ISBN { get; set; }
        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }


        [ForeignKey("KitapDetay")]
        public int KitapDetay_Id {  get; set; } 
       

        public KitapDetay KitapDetay {  get; set; }



        [ForeignKey("YayınEvi")]
        public int YayınEvi_Id { get; set; }

        public Yayınevi Yayınevi { get; set; }


    }
}
