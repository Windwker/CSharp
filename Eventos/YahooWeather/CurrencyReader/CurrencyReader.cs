using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Net;

namespace CurrencyReader
{
    public class CurrencyReader : INotifyPropertyChanged{


        public string Currency { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Read()
        {
            //double currency;
            string url = "http://www.apilayer.net/api/live?access_key=e02af223dc6bfab453c7abb82e6ff5ca&currencies=ARS";
            WebClient client = new WebClient();
            string query =  (client.DownloadString(url));
            JObject jObject = JObject.Parse(query);
            JToken usdCurrency = jObject.SelectToken("quotes").SelectToken("USDARS");
            Currency = (usdCurrency.ToString());
            //OnPropertyChanged("Currency");
            //Console.WriteLine(usdCurrency);


        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventArgs propertyChangedEventArgs = new PropertyChangedEventArgs(propertyName);
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, propertyChangedEventArgs);  
            }
        }

        }
}
