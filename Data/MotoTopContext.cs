using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public class MotoTopContext : DbContext
    {
        public MotoTopContext() : base()
        {
        }
        public MotoTopContext(DbContextOptions<MotoTopContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



        }
        public void ConfigureServices(IServiceCollection services)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // claves compuestas
            modelBuilder.Entity<ProductDiscount>()
              .HasKey(p => new { p.ProductId, p.ProductDiscountId });
            modelBuilder.Entity<SellerClient>()
             .HasKey(svc => new { svc.SellerId, svc.ClientId });
            // enums a string
            modelBuilder
                .Entity<Order>()
                .Property(d => d.ShipmentStatus)
                .HasConversion(new EnumToStringConverter<ShipmentStatuses>());
            modelBuilder
                .Entity<BillingTransaction>()
                .Property(bt => bt.PaymentMethod)
                .HasConversion(new EnumToStringConverter<PaymentMethods>());
            modelBuilder
                .Entity<User>()
                .Property(u => u.Role)
                .HasConversion(new EnumToStringConverter<Roles>());
            modelBuilder
                .Entity<Client>()
                .Property(c => c.DocumentType)
                .HasConversion(new EnumToStringConverter<PersonDocType>());
            modelBuilder
                .Entity<User>()
                .Property(u => u.DocumentType)
                .HasConversion(new EnumToStringConverter<PersonDocType>());
            // no action para ON DELETE
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderProducts)
                .WithOne(op => op.Order)
                .OnDelete(DeleteBehavior.Cascade);
        }
        // Entities tables
        public DbSet<BillingTransaction> BillingTransactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> ProductDiscounts { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<TransportCompany> TransportCompanies { get; set; }
        //Relationship tables
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ProductDiscount> ProductHasDiscounts { get; set; }
        public DbSet<SellerClient> SellerClientVisits { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
    }
}