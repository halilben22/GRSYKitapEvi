﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Models.Models
{


    [Table("tb_kategoriler")]
    public class Kategori
    {    


        
        public int KategoriId { get; set; }
        public string KategoriAd  { get; set; }




    }
} 
