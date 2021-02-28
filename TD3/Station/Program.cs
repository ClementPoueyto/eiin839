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
        static async Task Main(string[] args)
        {
           

                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string url = "https://api.jcdecaux.com/vls/v3/";
                    string data = "stations";
                    string apiKey = "1e8fa1e0e4cf13b66a513ec8f8c2efaf51a4f3f9";
                    string contract;
                    string number;

                    if (args.Length > 0)

                    {
                        number = args[0];

                        contract = args[1];
                    }
                    else
                    {
                        Console.WriteLine("Number :");

                        number = Console.ReadLine();
                        Console.WriteLine("Contract :");

                        contract = Console.ReadLine();

                    }
                    HttpResponseMessage response = await client.GetAsync(url + data + "/" + number + "?contract=" + contract + "&apiKey=" + apiKey);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Station station = JsonSerializer.Deserialize<Station>(responseBody);
                    Console.WriteLine(station);

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
