using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Models.Models
{
    public class KitapDetay
    {
        [Key]
        public int KitapDetay_Id { get; set; }

        [Required]
        public int BolumSayisi { get; set; }

        public int KitapSayfasi { get; set; }

        public double KitapAgirlik{ get; set; }

        public Kitap Kitap {  get; set; }

    }
}
