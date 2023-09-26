using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;

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

            optionsBuilder.UseSqlServer("Server=LUDMILA\\SQLEXPRESS;Database=mototop;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // claves compuestas
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.ProductId, op.OrderId });
            modelBuilder.Entity<ProductHasDiscount>()
              .HasKey(p => new { p.ProductId, p.ProductDiscountId });
            modelBuilder.Entity<SellerVisitClient>()
             .HasKey(svc => new { svc.SellerId, svc.ClientId });
            modelBuilder.Entity<SupplierProvidesProduct>()
               .HasKey(spp => new { spp.ProductId, spp.SupplierId });
            // enums a string
            modelBuilder
                .Entity<Order>()
                .Property(d => d.ShipmentStatus)
                .HasConversion(new EnumToStringConverter<ShipmentStatuses>());
            modelBuilder
                .Entity<BillingTransaction>()
                .Property(d => d.PaymentMethod)
                .HasConversion(new EnumToStringConverter<PaymentMethods>());
        }
        // Entities tables
        public DbSet<BillingTransaction> BillingTransactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<TransportCompany> TransportCompanies { get; set; }
        //Relationship tables
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ProductHasDiscount> ProductHasDiscounts { get; set; }
        public DbSet<SellerVisitClient> SellerClientVisits { get; set; }
        public DbSet<SupplierProvidesProduct> SupplierProducts { get; set; }
    }
}