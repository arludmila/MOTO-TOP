﻿using Bogus;
using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Entities.Core;
using Entities.Enums;

namespace DBSeeders
{
    public static class Generators
    {
        // ok
        public static async Task GenerateCategories()
        {
            string[] motorcycleParts = { "Motor", "Neumáticos", "Frenos", "Suspensión", "Escape", "Transmisión", "Faros", "Cadena", "Carburador", "Batería", "Manillar", "Asiento", "Rueda delantera", "Rueda trasera", "Amortiguadores", "Refrigeración", "Embrague", "Encendido", "Filtro de aire", "Carenado" };
            for (int i = 0; i < motorcycleParts.Count(); i++)
            {
                var category = new CategoryDto
                {
                    Name = motorcycleParts[i],
                };
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/categories", category));
            }
        } 
        // no
        public static async Task GenerateProducts(int quantity)
        {
            var categories = await ApiHelper.GetAsync<Category>("https://localhost:7215/api/categories");
            var productFaker = new Faker<ProductDto>()
            .RuleFor(x => x.Name, f => f.Vehicle.Manufacturer())
            .RuleFor(x => x.Quantity, f => f.Random.Number(20, 100))
            //.RuleFor(x => x.Price, f => f.Random.Double(1000, 50000))
            .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id)
            .RuleFor(x => x.Description, f => f.Vehicle.Model());
            for (int i = 0; i < quantity; i++)
            {
                var product = productFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/products", product));
            }
        }
        public static async Task GenerateSuppliers(int quantity)
        {
            var supplierFaker = new Faker<SupplierDto>()
                .RuleFor(x => x.Name, f => f.Company.CompanyName())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat());
            for (int i = 0; i < quantity; i++)
            {
                var supplier = supplierFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/suppliers", supplier));
            }
        }
        public static async Task GenerateSupplierProducts(int quantity)
        {
            var suppliers = await ApiHelper.GetAsync<Supplier>("https://localhost:7215/api/suppliers");
            var products = await ApiHelper.GetAsync<Product>("https://localhost:7215/api/products");

            var supplierProductsFaker = new Faker<SupplierProductDto>()
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
                .RuleFor(x => x.SupplierId, f => f.PickRandom(suppliers).Id);
            for (int i = 0; i < quantity; i++)
            {
                var supplierProduct = supplierProductsFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/supplier-products", supplierProduct));
            }
        }
        public static async Task GenerateDiscounts(int quantity)
        {
            var discountsFaker = new Faker<DiscountDto>()
               .RuleFor(x => x.Percentage, f => f.Random.Float(0, 0.5f))
               .RuleFor(x => x.Description, f => f.Lorem.Sentence(50));
            for (int i = 0; i < quantity; i++)
            {
                var discount = discountsFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/discounts", discount));
            }
        }
        // ok
        public static async Task GenerateSellers(int quantity)
        {
            string[] ciudadesCorrientes = {
                "Corrientes",
                "Goya",
                "Mercedes",
                "Esquina",
                "Bella Vista",
                "Curuzú Cuatiá"
            };

            var sellers = new Faker<SellerRegisterDto>()
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Zone, f => f.PickRandom(ciudadesCorrientes))
                .RuleFor(x => x.Email, f => f.Internet.Email()) // Generate a random email
                .RuleFor(x => x.PasswordHash, f => "your_password_hash_here") // Set a password hash
                .RuleFor(x => x.DocumentType, f => PersonDocType.DNI) // Set the document type
                .RuleFor(x => x.DocumentNumber, f => f.Random.Number(10000000, 99999999).ToString()); // Generate a random document number

            for (int i = 0; i < quantity; i++)
            {
                var seller = sellers.Generate();
                seller.Role = Roles.Seller; // Set the Role to 1 (Seller)
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/sellers/register", seller));
            }
        }
        // ok
        public static async Task GenerateClients(int quantity)
        {
            string[] ciudadesCorrientes = {
                "Corrientes",
                "Goya",
                "Mercedes",
                "Esquina",
                "Bella Vista",
                "Curuzú Cuatiá"
            };
            var clients = new Faker<ClientDto>()
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                 .RuleFor(x => x.DocumentType, f => PersonDocType.DNI) // Set the document type
                .RuleFor(x => x.DocumentNumber, f => f.Random.Number(10000000, 99999999).ToString())
                .RuleFor(x => x.Location, f => f.PickRandom(ciudadesCorrientes) + ", " + f.Address.StreetAddress())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat(12));
            for (int i = 0; i < quantity; i++)
            {
                var client = clients.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/clients", client));
            }
        }
        // ok
        public static async Task GenerateTransportCompanies()
        {
            string[] companyNames = {
                "Transporte XYZ",
                "Logística ABC",
                "Envíos Rápidos SRL",
                "Mensajería Express",
                "TransCorrientes",
                "EnvíoSeguro SA"
            };

            string[] phoneNumbers = {
                "+54123456789",
                "+54234567890",
                "+54345678901",
                "+54456789012",
                "+54567890123"
            };

            foreach (string companyName in companyNames)
            {
                // Seleccionar un número de teléfono aleatorio de la lista
                string phoneNumber = phoneNumbers[new Random().Next(phoneNumbers.Length)];

                // Crear el DTO de la empresa de transporte

                TransportCompanyDto transportCompany = new TransportCompanyDto
                {
                    Name = companyName,
                    PhoneNumber = phoneNumber,
                    Email = $"{companyName.Replace(" ", "").ToLower()}@example.com",
                };

                // Llamar a la API para agregar la empresa de transporte
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/transport-companies", transportCompany));
            }
        }
        public static async Task GenerateSellerClients(int quantity)
        {
            //var sellers = await ApiHelper.GetAsync<Seller>("https://localhost:7215/api/sellers");
            //var clients = await ApiHelper.GetAsync<Client>("https://localhost:7215/api/clients");
            //var sellerClientsFaker = new Faker<SellerClientDto>()
            //   .RuleFor(x => x.ClientId, f => f.PickRandom(clients).Id)
            //   .RuleFor(x => x.SellerId, f => f.PickRandom(sellers).Id)
            //   .RuleFor(x => x.Date, f => f.Date.Future());
            //for (int i = 0; i < quantity; i++)
            //{
            //    var sellerClient = sellerClientsFaker.Generate();
            //    Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/seller-clients", sellerClient));
            //}
        }
        public static async Task GenerateOrders(int quantity)
        {
            var sellers = await ApiHelper.GetAsync<Seller>("https://localhost:7215/api/sellers");
            var clients = await ApiHelper.GetAsync<Client>("https://localhost:7215/api/clients");
            var transportCompanies = await ApiHelper.GetAsync<TransportCompany>("https://localhost:7215/api/transport-companies");
            var ordersFaker = new Faker<OrderDto>()
               .RuleFor(x => x.ClientId, f => f.PickRandom(clients).Id)
               .RuleFor(x => x.SellerId, f => f.PickRandom(sellers).Id)
               .RuleFor(x => x.TransportCompanyId, f => f.PickRandom(transportCompanies).Id);
            //        .RuleFor(x => x.DateSent, f => f.Date.Past());
            for (int i = 0; i < quantity; i++)
            {
                var order = ordersFaker.Generate();
                //    order.ShipmentStatus = Entities.Enums.ShipmentStatuses.Shipped;
                //  order.DateReceived = order.DateSent.AddDays(3);
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/orders", order));
            }
        }
        public static async Task GenerateOrderProducts(int quantity)
        {
            var products = await ApiHelper.GetAsync<Product>("https://localhost:7215/api/products");
            var orders = await ApiHelper.GetAsync<Order>("https://localhost:7215/api/orders");
            var orderProductsFaker = new Faker<OrderProductDto>()
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
                 //  .RuleFor(x => x.OrderId, f => f.PickRandom(orders).Id)
                 .RuleFor(x => x.Quantity, f => f.Random.Number(1, 5))
                 .RuleFor(x => x.Price, f => f.Random.Double(1000, 50000));
            for (int i = 0; i < quantity; i++)
            {
                var orderProduct = orderProductsFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/order-products", orderProduct));
            }
        }
        public static async Task GenerateInvoices()
        {
            var orders = await ApiHelper.GetAsync<Order>("https://localhost:7215/api/orders");
            var invoicesFaker = new Faker<InvoiceDto>()
                .RuleFor(x => x.Date, f => f.Date.Recent(1));
            /*foreach (var order in orders)
            {
                var invoiceExists = (bool)await ApiHelper.GetAsync($"https://localhost:7215/api/invoices/orderHasInvoice/{order.Id}");
                if (!invoiceExists)
                {
                    var invoice = invoicesFaker.Generate();
                    invoice.OrderId = order.Id;
                    invoice.Amount = Convert.ToDouble(await ApiHelper.GetAsync($"https://localhost:7215/api/orders/getOrderTotal/{order.Id}"));
                    Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/invoices", invoice));

                }
            }*/
        }

    }
}
