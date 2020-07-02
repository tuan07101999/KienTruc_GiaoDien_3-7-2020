using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("QLRapPhim")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Ghe> ghes { get; set; }
        public DbSet<KhungGio> khungGios { get; set; }
        public DbSet<Phim> phims { get; set; }
        public DbSet<RapPhim> rapPhims { get; set; }
        public DbSet<SuatChieu> suatChieus { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Ve> ves { get; set; }

        //protected override OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }

    
}
