using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace YahooWeatherReader
{
    public class YahooWeatherReader
    {
        public void Read(string address)
        {
            WebClient client = new WebClient();
            try
            {
                string reply = client.DownloadString(address);
                JObject query = JObject.Parse(reply);
                JToken temp = new JObject();
                JToken info = new JObject();
                JToken date = new JObject();
                JToken condition = new JObject();
                

                temp = query.SelectToken("query").SelectToken("results").SelectToken("channel").SelectToken("item").SelectToken("condition").SelectToken("temp");
                info = query.SelectToken("query").SelectToken("results").SelectToken("channel").SelectToken("description");
                date = query.SelectToken("query").SelectToken("results").SelectToken("channel").SelectToken("lastBuildDate");
                condition = query.SelectToken("query").SelectToken("results").SelectToken("channel").SelectToken("item").SelectToken("condition").SelectToken("text");

                Console.WriteLine(info);
                Console.WriteLine("Date: " + date);
                Console.WriteLine("Actual temperature " + FahrenheitToCelciusConverter.Convert(temp));
                Console.WriteLine("Day Status: " + condition);
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           

            
            

        }
    }
}
