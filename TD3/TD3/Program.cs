using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace TD3
{
    class Program
    {

        static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://api.jcdecaux.com/vls/v3/";
                string data = "stations";
                string apiKey = "1e8fa1e0e4cf13b66a513ec8f8c2efaf51a4f3f9";
                string contract = "brisbane";
                HttpResponseMessage response = await client.GetAsync(url + data + "?contract=brisbane&apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Station[] stations = JsonSerializer.Deserialize<Station[]>(responseBody);
                for (int i = 0; i < stations.Length; i++)
                {
                    Console.WriteLine(stations[i]);
                }
                Console.ReadLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
