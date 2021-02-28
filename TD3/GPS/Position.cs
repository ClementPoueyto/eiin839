using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    public class Position
    {
        public Double lat { get; set; }
        public Double lng { get; set; }

        public Position()
        {

        }

        public Position(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lng = longitude;
        }

        public override string ToString()
        {
            return "latitude : " + this.lat + "\n" +
                "longitude : " + this.lng;
        }
    }
}
