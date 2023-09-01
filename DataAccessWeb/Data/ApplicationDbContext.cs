using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelWeb.Administration;
using ModelWeb.Models;

namespace DataAccessWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region IdentityRole
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" });

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole() { Name = "Moderator", NormalizedName = "Moderator" });

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole() { Name = "User", NormalizedName = "User" });
            #endregion

            #region TableNames
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            #endregion

            #region Products10
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 1,
                    Title = "T-Shirt",
                    Description = "Dark Red",
                    Price = 21,
                    Quantity = 5
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 2,
                    Title = "Pen",
                    Description = "The GoldOne",
                    Price = 300,
                    Quantity = 2
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 3,
                    Title = "Wine",
                    Description = "Red Wine with 20% alcohol",
                    Price = 115,
                    Quantity = 45
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 4,
                    Title = "Azure License",
                    Description = "Full Subscription on Azure platform (License)",
                    Price = 2500,
                    Quantity = 3
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 5,
                    Title = "XXL Shirt",
                    Description = "Super GREEN",
                    Price = 20,
                    Quantity = 3
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 6,
                    Title = "Fork",
                    Description = "Ancient fork from China",
                    Price = 33,
                    Quantity = 2000
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 7,
                    Title = "RedHat License",
                    Description = "license for RedHat distro in 15% OFF , def. nije piratizirano",
                    Price = 15,
                    Quantity = 5498
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 8,
                    Title = "XXL Hat",
                    Description = "Super Big Hat for Winter",
                    Price = 15,
                    Quantity = 51
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 9,
                    Title = "Nvidia 200NN",
                    Description = "GPU Nvidia",
                    Price = 475,
                    Quantity = 6
                });
            builder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 10,
                    Title = "Carpet",
                    Description = "Big Green Carpet",
                    Price = 190,
                    Quantity = 3
                });
            #endregion

            #region Categories3
            builder.Entity<Category>()
            .HasData(new Category() { Id = 1, Title = "IT" });

            builder.Entity<Category>()
            .HasData(new Category() { Id = 2, Title = "Goods" });

            builder.Entity<Category>()
            .HasData(new Category() { Id = 3, Title = "Kitchen stuff" });

            builder.Entity<Category>()
            .HasData(new Category() { Id = 4, Title = "Limited Edition" });

            builder.Entity<Category>()
            .HasData(new Category() { Id = 5, Title = "Unknown" });
            #endregion


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N89DPOR\\SQLEXPRESS;Database=ModelWeb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}