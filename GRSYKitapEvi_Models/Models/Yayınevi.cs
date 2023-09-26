using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Models.Models
{
    [Table("tb_Yayinevi")]
    public class Yayınevi
    {

        [Key]
        public int YayınEvi_Id { get; set; }
        public string YayınEviAdi { get; set; }
        public string Lokasyon { get; set; }


        public List<Kitap> Kitap { get; set; }

    }
}
