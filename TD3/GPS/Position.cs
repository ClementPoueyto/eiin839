using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    public class Position
    {
        public Double latitude { get; set; }
        public Double longitude { get; set; }

        public Position()
        {

        }

        public Position(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public override string ToString()
        {
            return "latitude : " + this.latitude + "\n" +
                "longitude : " + this.longitude;
        }
    }
}
