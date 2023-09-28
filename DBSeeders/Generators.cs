using Bogus;
using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Entities.Core;
using Entities.Relationships;

namespace DBSeeders
{
    public static class Generators
    {
        public static async Task GenerateCategories(int quantity)
        {
            var categoryFaker = new Faker<CategoryDto>()
            .RuleFor(x => x.Name, f => f.Vehicle.Manufacturer() + " Parts");
            for (int i = 0; i < quantity; i++)
            {
                var category = categoryFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Categories", category));
            }
        }
        public static async Task GenerateProducts(int quantity)
        {
            var categories = await ApiHelper.GetAsync<Category>("https://localhost:7215/api/Categories");
            var productFaker = new Faker<ProductDto>()
            .RuleFor(x => x.Name, f => f.Commerce.Product())
            .RuleFor(x => x.Quantity, f => f.Random.Number(20, 100))
            .RuleFor(x => x.Price, f => f.Random.Double(1000, 50000))
            .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id)
            .RuleFor(x => x.Description, f => f.Vehicle.Model());
            for (int i = 0; i < quantity; i++)
            {
                var product = productFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Products", product));
            }
        }
        public static async Task GenerateSuppliers(int quantity)
        {
            var supplierFaker = new Faker<SupplierDto>()
                .RuleFor(x=>x.Name, f=> f.Company.CompanyName())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat(12));
            for (int i = 0; i < quantity; i++)
            {
                var supplier = supplierFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Suppliers", supplier));
            }
        }
        public static async Task GenerateSupplierProducts(int quantity)
        {
            var suppliers = await ApiHelper.GetAsync<Supplier>("https://localhost:7215/api/Suppliers");
            var products = await ApiHelper.GetAsync<Product>("https://localhost:7215/api/Products");

            var supplierProductsFaker = new Faker<SupplierProductDto>()
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
                .RuleFor(x => x.SupplierId, f => f.PickRandom(suppliers).Id);
            for (int i = 0; i < quantity; i++)
            {
                var supplierProduct = supplierProductsFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/SupplierProducts", supplierProduct));
            }
        }
        public static async Task GenerateDiscounts(int quantity)
        {
            var discountsFaker = new Faker<DiscountDto>()
               .RuleFor(x => x.Percentage, f => f.Random.Float(0,1))
               .RuleFor(x => x.Description, f => f.Lorem.Sentence(50));
            for (int i = 0; i < quantity; i++)
            {
                var discount = discountsFaker.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Discounts", discount));
            }
        }
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
            var sellers = new Faker<SellerDto>()
                .RuleFor(x => x.Name, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x=>x.Zone, f=> f.PickRandom(ciudadesCorrientes));
            for (int i = 0; i < quantity; i++)
            {
                var seller = sellers.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Sellers", seller));
            }
        }
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
                .RuleFor(x => x.Name, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Location, f => f.PickRandom(ciudadesCorrientes)+", "+f.Address.StreetAddress())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat(12));
            for (int i = 0; i < quantity; i++)
            {
                var client = clients.Generate();
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/Clients", client));
            }
        }
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
                    PhoneNumber = phoneNumber
                };

                // Llamar a la API para agregar la empresa de transporte
                Console.WriteLine(await ApiHelper.PostAsync("https://localhost:7215/api/TransportCompanies", transportCompany));
            }
        }
        public static async Task GenerateSellerClients()
        {

        }

    }
}
