using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace YahooWeatherReader
{
    class Program
    {
        static void Main(string[] args)
        {
            YahooWeatherReader reader = new YahooWeatherReader();
            string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20woeid%20%3D%20466861%20)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            reader.Read(url);
        }
    }

    public class FahrenheitToCelciusConverter
    {
        public static double Convert(JToken jobject)
        {
            var fahrenheit = double.Parse(jobject.ToString());
            var celcius = (fahrenheit - 32) / 1.8;
            return celcius;
        }
    }
}
