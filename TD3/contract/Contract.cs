using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace contract
{
    class Contract
    {
        public String name { get; set; }
        public String commercial_name { get; set; }
        public String[] cities { get; set; }
        public String country_code { get; set; }

        public Contract(string name, string commercial_name, string[] cities, string country_code)
        {
            this.name = name;
            this.commercial_name = commercial_name;
            this.cities = cities;
            this.country_code = country_code;
        }

        public Contract()
        {

        }

        public string Commercial_name { get => commercial_name; set => commercial_name = value; }
        public string[] Cities { get => cities; set => cities = value; }
        public string Country_code { get => country_code; set => country_code = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return "name : " + this.name + "\n" +
                "commercial_name : " + this.commercial_name + "\n" +
                "cities : " + this.cities + "\n" +
                "country_code : " + this.country_code + "\n";
                }



    }
}
