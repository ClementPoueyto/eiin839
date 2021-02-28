using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Device;

namespace TD3
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {


            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://api.jcdecaux.com/vls/v3/";
                string data = "stations";
                string apiKey = "1e8fa1e0e4cf13b66a513ec8f8c2efaf51a4f3f9";
                string lat;
                string lng;

                if (args.Length > 0)

                {
                    lat = args[0];

                    lng = args[1];
                }
                else
                {
                    Console.WriteLine("latitude :");

                    lat = Console.ReadLine();
                    Console.WriteLine("longitude :");

                    lng = Console.ReadLine();

                }
                HttpResponseMessage response = await client.GetAsync(url + data + "?apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Station[] stations = JsonSerializer.Deserialize <Station[]> (responseBody);
                Station station;
                foreach(Station s in stations)
                {

                    break;
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
