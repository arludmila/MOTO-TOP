using Business.Services;
using Business.Services.Entities;
using Business.Services.Relationships;
using Data;
using Data.Repositories;
using Data.Repositories.Entities;
using Data.Repositories.Relationships;
using Entities.Core;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json.Serialization;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7224");
                          policy.WithOrigins("https://localhost:7236");
                          policy.WithOrigins("https://localhost:7021");
                      });
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowEmulator",
        builder => builder.WithOrigins("http://10.0.2.2:YOUR_EMULATOR_PORT")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// DI
builder.Services.AddDbContext<MotoTopContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("MotoTopDatabase")
                    ));
//// Define an array of types you want to use
//Type[] entityTypes = new Type[]
//{
//    typeof(Category),
//    typeof(Client),
//    typeof(Supplier),
//    typeof(Product),
//    typeof(Seller),
//    typeof(TransportCompany),
//    typeof(Order),
//    typeof(Discount),
//    typeof(Invoice),
//    typeof(BillingTransaction),
//    typeof(OrderProduct),
//    typeof(ProductDiscount),
//    typeof(SellerClient),
//    typeof(SupplierProduct),
//};

//// Use a foreach loop to register the generic types
//foreach (Type entityType in entityTypes)
//{
//    Type repositoryType = typeof(GenericRepository<>).MakeGenericType(entityType);
//    Type serviceType = typeof(GenericService<>).MakeGenericType(entityType);

//    builder.Services.AddScoped(repositoryType);
//    builder.Services.AddScoped(serviceType);
//}
// Inject GenericRepository and GenericService for Category
builder.Services.AddScoped(typeof(GenericRepository<Category, int>));
builder.Services.AddScoped(typeof(GenericService<Category, int>));

// Inject GenericRepository and GenericService for Client
builder.Services.AddScoped(typeof(GenericRepository<Client, int>));
builder.Services.AddScoped(typeof(GenericService<Client, int>));

// Inject GenericRepository and GenericService for Supplier
builder.Services.AddScoped(typeof(GenericRepository<Supplier, int>));
builder.Services.AddScoped(typeof(GenericService<Supplier, int>));

// Inject GenericRepository and GenericService for Product
builder.Services.AddScoped(typeof(GenericRepository<Product, int>));
builder.Services.AddScoped(typeof(GenericService<Product, int>));

// Inject GenericRepository and GenericService for Seller
builder.Services.AddScoped(typeof(GenericRepository<Seller, int>));
builder.Services.AddScoped(typeof(GenericService<Seller, int>));

// Inject GenericRepository and GenericService for TransportCompany
builder.Services.AddScoped(typeof(GenericRepository<TransportCompany, int>));
builder.Services.AddScoped(typeof(GenericService<TransportCompany, int>));

// Inject GenericRepository and GenericService for Order
builder.Services.AddScoped(typeof(GenericRepository<Order, int>));
builder.Services.AddScoped(typeof(GenericService<Order, int>));

// Inject GenericRepository and GenericService for Discount
builder.Services.AddScoped(typeof(GenericRepository<Discount, int>));
builder.Services.AddScoped(typeof(GenericService<Discount, int>));

// Inject GenericRepository and GenericService for Invoice
builder.Services.AddScoped(typeof(GenericRepository<Invoice, int>));
builder.Services.AddScoped(typeof(GenericService<Invoice, int>));

// Inject GenericRepository and GenericService for BillingTransaction
builder.Services.AddScoped(typeof(GenericRepository<BillingTransaction, int>));
builder.Services.AddScoped(typeof(GenericService<BillingTransaction, int>));

// Inject GenericRepository and GenericService for OrderProduct
builder.Services.AddScoped(typeof(GenericRepository<OrderProduct, int>));
builder.Services.AddScoped(typeof(GenericService<OrderProduct, int>));

// Inject GenericRepository and GenericService for ProductDiscount
builder.Services.AddScoped(typeof(GenericRepository<ProductDiscount, int>));
builder.Services.AddScoped(typeof(GenericService<ProductDiscount, int>));

// Inject GenericRepository and GenericService for SellerClient
builder.Services.AddScoped(typeof(GenericRepository<SellerClient, int>));
builder.Services.AddScoped(typeof(GenericService<SellerClient, int>));

// Inject GenericRepository and GenericService for SupplierProduct
builder.Services.AddScoped(typeof(GenericRepository<SupplierProduct, int>));
builder.Services.AddScoped(typeof(GenericService<SupplierProduct, int>));
// Inject GenericRepository and GenericService for OffWorker
builder.Services.AddScoped(typeof(GenericRepository<OfficeWorker, int>));
builder.Services.AddScoped(typeof(GenericService<OfficeWorker, int>));
builder.Services.AddScoped<OrderRepository>();

builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<InvoiceRepository>();

builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<BillingTransactionRepository>();
builder.Services.AddScoped<BillingTransactionService>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<SellerRepository>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<SupplierProductRepository>();
builder.Services.AddScoped<SupplierProductService>();
builder.Services.AddScoped<OfficeWorkerRepository>();
builder.Services.AddScoped<OfficeWorkerService>();
builder.Services.AddScoped<ReportRepository>();
builder.Services.AddScoped<ReportService>();


builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowEmulator");
app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin  
    .AllowCredentials());
app.MapControllers();

app.Run();
