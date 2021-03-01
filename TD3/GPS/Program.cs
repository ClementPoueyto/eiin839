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
                double lat;
                double lng;

                if (args.Length > 0)

                {
                    lat = Double.Parse(args[0]);

                    lng = Double.Parse(args[1]);
                }
                else
                {
                    Console.WriteLine("latitude :");

                    lat = Double.Parse(Console.ReadLine());
                    Console.WriteLine("longitude :");

                    lng = Double.Parse(Console.ReadLine());

                }
                HttpResponseMessage response = await client.GetAsync(url + data + "?apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Station[] stations = JsonSerializer.Deserialize <Station[]> (responseBody);
                Station station = new Station();
                double distance = -1;
                foreach(Station s in stations)
                {
              

                    double newDistance = GetDistance(lng, lat, s.position.longitude, s.position.latitude);
                    //Console.WriteLine(newDistance +"    "+ s.position.longitude+" "+s.position.latitude);
                    if (distance==-1 || distance > newDistance)
                    {
                        
                        distance = newDistance;
                        station = s;
                    }
                }
                Console.WriteLine(station.ToString());
                Console.ReadLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        public static double GetDistance(double longitude, double latitude, double otherLongitude, double otherLatitude)
        {
            var d1 = latitude * (Math.PI / 180.0);
            var num1 = longitude * (Math.PI / 180.0);
            var d2 = otherLatitude * (Math.PI / 180.0);
            var num2 = otherLongitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

    }


}
