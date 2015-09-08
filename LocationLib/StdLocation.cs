using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationLib
{
    public class StdLocation
    {
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }

        public string ToDisplayString()
        {
            if (CountryCode == "US")
            {
                return string.Format("{0}, {1}", City, Region);
            }
            else
            {
                if (String.IsNullOrEmpty(City))
                {
                    return Country;
                }
                else
                {
                    return string.Format("{0}, {1}", City, Country);
                }
            }
        }

    }
}
