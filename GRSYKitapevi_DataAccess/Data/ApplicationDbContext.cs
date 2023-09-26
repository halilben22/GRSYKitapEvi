using GRSYKitapEvi_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapevi_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base
            (options)
        {
               

        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yayınevi> YayınEvleri{ get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

    }
}
