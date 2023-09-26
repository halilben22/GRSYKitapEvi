using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Models.Models
{
    [Table("tb_Yazar")]
    public class Yazar
    {

        [Key]
        public int Yazar_Id { get; set; }
        [Required]
        public string Yazar_Ad { get;set; }

        [Required]
        public string Yazar_Soyad { get; set; }
        public string Lokasyon { get; set; }

        [Required]
        public DateTime Yazar_Dogum_Tarihi {  get; set; }


        [NotMapped]
        public string AdSoyad
        {
            get

            { return $"{Yazar_Ad} {Yazar_Soyad} "; }

                 }
    
    
    
    
    }
}
