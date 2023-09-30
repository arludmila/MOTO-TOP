// See https://aka.ms/new-console-template for more information
using Bogus;
using Contracts.DTOs.Entities;
using DBSeeders;
using Newtonsoft.Json;
using System.Text;

Console.WriteLine("Press to start:");
Console.ReadLine();
//await Generators.GenerateCategories(); // Example: Generate 5 categories
//await Generators.GenerateProducts(30);   // Example: Generate 10 products
//await Generators.GenerateSuppliers(5);   // Example: Generate 3 suppliers
//await Generators.GenerateSupplierProducts(17); // Example: Generate 7 supplier products
//await Generators.GenerateDiscounts(4);   // Example: Generate 4 discounts
//await Generators.GenerateSellers(7);      // Example: Generate 6 sellers
//await Generators.GenerateClients(15);      // Example: Generate 8 clients
//await Generators.GenerateTransportCompanies(); // Generate transport companies
//await Generators.GenerateSellerClients(9);
//await Generators.GenerateOrders(7);
//await Generators.GenerateOrderProducts(14);
await Generators.GenerateInvoices();
Console.WriteLine("Press to close:");
Console.ReadLine();