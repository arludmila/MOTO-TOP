// See https://aka.ms/new-console-template for more information
using Bogus;
using Contracts.DTOs.Entities;
using DBSeeders;
using Newtonsoft.Json;
using System.Text;

Console.WriteLine("Press to start:");
Console.ReadLine();
await Generators.GenerateTransportCompanies();
Console.WriteLine("Press to close:");
Console.ReadLine();