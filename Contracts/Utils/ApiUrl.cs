using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Utils
{
    public static class ApiUrl
    {
        public static string AzureUrl { get; } = "https://moto-top.azurewebsites.net/api/";
        public static string LocalUrl { get; } = "https://localhost:7215/api/";
    }
}
