using Microsoft.EntityFrameworkCore;
using Uniqlo.Models;

namespace Uniqlo.DataAccess
{
    public class UniqloDbContext : DbContext
    {
        public DbSet<Slider> Sliders {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<ProductImage> ProductImages {  get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-MJLOCD2;Database=UniqloDB;Trusted_Connection=True;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public UniqloDbContext (DbContextOptions opt):base(opt) { }
    }
}
