using FragrantWorld.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld.Context
{
    public class FragrantWorldContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PickUpPoint> PickUpPoints { get; set; }
        public DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SUPERTOOL\\SQLEXPRESS;Database=FragrantWorld;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();

            modelBuilder.Entity<Role>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Manufacturer>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Supplier>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<UnitOfMeasurement>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<ProductCategory>().HasIndex(u => u.Name).IsUnique();


            modelBuilder.Entity<PickUpPoint>().HasIndex(u => u.Index).IsUnique();
            modelBuilder.Entity<Order>().HasKey(x => new {x.Number, x.ProductArticleNumber});

            modelBuilder.Entity<Cart>().HasIndex(x => new { x.ProductArticleNumber, x.ClientId }).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}