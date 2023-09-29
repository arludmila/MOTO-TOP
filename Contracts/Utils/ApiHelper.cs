using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Utils
{
    public class ApiHelper
    {
        private static readonly HttpClient _httpClient = new();

        
        public static async Task<string> PostAsync(string url, object objectToPass)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(objectToPass);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    // Operation was successful
                    string successMessage = "Operation successful!";
                    return successMessage;
                }
                else
                {
                    // Operation failed
                    string errorMessage = "Operation failed. Status code: " + response.StatusCode;
                    return errorMessage;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or return an error message.
                string errorMessage = "An error occurred: " + ex.Message;
                return errorMessage;
            }
        }
        public static async Task<List<T>> GetAsync<T>(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // If the request was successful, read the content as a string
                    var content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON content into a list of objects of type T
                    List<T> result = JsonConvert.DeserializeObject<List<T>>(content);
                    return result;
                }
                else
                {
                    // Operation failed
                    string errorMessage = "Operation failed. Status code: " + response.StatusCode;
                    return null; // You can handle this error case as needed
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or return an error message.
                string errorMessage = "An error occurred: " + ex.Message;
                return null; // You can handle this error case as needed
            }
        }
        public static async Task<object> GetAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // If the request was successful, read the content as a string
                    var content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON content into a list of objects of type T
                    object result = JsonConvert.DeserializeObject(content);
                    return result;
                }
                else
                {
                    // Operation failed
                    string errorMessage = "Operation failed. Status code: " + response.StatusCode;
                    return null; // You can handle this error case as needed
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or return an error message.
                string errorMessage = "An error occurred: " + ex.Message;
                return null; // You can handle this error case as needed
            }
        }
    }
}
