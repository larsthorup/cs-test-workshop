using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var url = "http://api.openweathermap.org/data/2.5/weather?q=Copenhagen";
            var jsonString = client.DownloadString(url);
            var weatherData = JsonConvert.DeserializeObject<dynamic>(jsonString);
            Console.WriteLine(weatherData.weather[0].description);
        }
    }
}
