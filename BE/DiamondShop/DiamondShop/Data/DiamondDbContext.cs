using DiamondShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Security.Claims;

namespace FAMS.Entities.Data
{
    public class DiamondDbContext : DbContext
    {
		public DiamondDbContext()
		{

		}
		public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GetConnectionString());
			}
		}
		private string GetConnectionString()
		{
			IConfiguration config = new ConfigurationBuilder()
			 .SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", true, true)
			.Build();
			var strConn = /*config["ConnectionStrings:DB"]*/ config.GetConnectionString("EFDataContext");

			return strConn;
		}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints here

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductDetail)
                .WithMany()
                .HasForeignKey(p => p.ProductDetailId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Certificate)
                .WithOne() // Đây là mối quan hệ 1-1 giữa Product và Certificate
                .HasForeignKey<Product>(p => p.CertificateId);

            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.User)
                .WithMany(u => u.ShoppingCarts)
                .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.Product)
                .WithMany(p => p.ShoppingCarts)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);

            modelBuilder.Entity<Warranty>()
                .HasOne(w => w.User)
                .WithMany(u => u.Warranties)
                .HasForeignKey(w => w.UserId);

            modelBuilder.Entity<Warranty>()
                .HasOne(w => w.Product)
                .WithMany(p => p.Warranties)
                .HasForeignKey(w => w.ProductId);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.User)
                .WithMany(u => u.Feedbacks)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Product)
                .WithMany(p => p.Feedbacks)
                .HasForeignKey(f => f.ProductId);
        }
    }
}
