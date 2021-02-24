using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    class Station
    {
        public int number { get; set; }
        public String contract_name { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public Position position { get; set; }
        public Boolean banking { get; set; }
        public Boolean bonus { get; set; }

        public Station(int number, string contract_name, string name, string address, Position position, bool banking, bool bonus)
        {
            this.number = number;
            this.contract_name = contract_name;
            this.name = name;
            this.address = address;
            this.position = position;
            this.banking = banking;
            this.bonus = bonus;
        }

        public Station()
        {

        }

        public override string ToString()
        {
            return "name : " + this.name + "\n" +
                "contract_name : " + this.contract_name + "\n" +
                "number : " + this.number + "\n" +
                "position : " + this.position + "\n" +
                "banking : " + this.banking + "\n" +
                "bonus : " + this.bonus + "\n" +
                "address : " + this.address + "\n";
        }
    }
}
