using Microsoft.EntityFrameworkCore;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccsessLayer.Context
{
    public class FoodyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=foodydb;user=root;password=123456;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<About> About { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
