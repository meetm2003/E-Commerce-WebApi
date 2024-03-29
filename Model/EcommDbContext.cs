using Microsoft.EntityFrameworkCore;
namespace ecommerce.Model
{
    public class EcommDbContext : DbContext
    {
        public EcommDbContext(DbContextOptions<EcommDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasKey(o => o.O_Id);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.P_Id);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.U_Id);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.P_Id);

            modelBuilder.Entity<User>()
                .HasKey(u => u.U_Id);
        }
    }
}
