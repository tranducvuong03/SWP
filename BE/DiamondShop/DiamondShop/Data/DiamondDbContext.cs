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
            modelBuilder.Entity<Certificate>(entity =>
            {
                // Chỉ định kiểu dữ liệu cho trường CaratWeight
                entity.Property(e => e.CaratWeight).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                // Chỉ định kiểu dữ liệu cho trường TotalPrice
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                // Chỉ định kiểu dữ liệu cho trường Price
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                // Chỉ định kiểu dữ liệu cho trường Carat
                entity.Property(e => e.Carat).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<User>(e =>
			{
				e.ToTable("User");
				e.HasKey(x => x.userID);
				e.Property(x => x.username);
				e.Property(x => x.password);
				e.Property(x => x.email);
				e.Property(x => x.fullName);
				e.Property(x => x.status);
				e.Property(x => x.roleID);
				e.HasOne(x => x.role)
				.WithMany()
				.HasForeignKey(x => x.roleID);

			});
			modelBuilder.Entity<Role>(e =>
			{
				e.HasKey(x => x.roleID);
				e.Property(x => x.roleName);

			});

		}
	}
}
