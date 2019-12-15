using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPLocation
{
    public class GetIpModel
    {
        public double longitude { get; set; }
        public string city { get; set; }
        public string timezone { get; set; }
        public int offset { get; set; }
        public string region { get; set; }
        public int asn { get; set; }
        public string organization { get; set; }
        public string country { get; set; }
        public string ip { get; set; }
        public double latitude { get; set; }
        public string continent_code { get; set; }
        public string country_code { get; set; }
        public string region_code { get; set; }
    }
}
