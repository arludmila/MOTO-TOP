using Business.Services;
using Business.Services.Entities;
using Data;
using Data.Repositories;
using Data.Repositories.Entities;
using Entities.Core;
using Entities.Relationships;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// DI
builder.Services.AddDbContext<MotoTopContext>();
// Define an array of types you want to use
Type[] entityTypes = new Type[]
{
    typeof(Category),
    typeof(Client),
    typeof(Supplier),
    typeof(Product),
    typeof(Seller),
    typeof(TransportCompany),
    typeof(Order),
    typeof(Discount),
    typeof(Invoice),
    typeof(BillingTransaction),
    typeof(OrderProduct),
    typeof(ProductDiscount),
    typeof(SellerClient),
    typeof(SupplierProduct),
};

// Use a foreach loop to register the generic types
foreach (Type entityType in entityTypes)
{
    Type repositoryType = typeof(GenericRepository<>).MakeGenericType(entityType);
    Type serviceType = typeof(GenericService<>).MakeGenericType(entityType);

    builder.Services.AddScoped(repositoryType);
    builder.Services.AddScoped(serviceType);
}
builder.Services.AddScoped<OrderRepository>();

builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<InvoiceRepository>();

builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<BillingTransactionRepository>();

builder.Services.AddScoped<BillingTransactionService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
