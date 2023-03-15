using DTO;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;

namespace BUS
{
    public class Weather_BUS
    {
        readonly string location = ConfigurationManager.AppSettings.Get("Location");
        readonly string apiKey = ConfigurationManager.AppSettings.Get("APIKey");

        public Tuple<string, string, string> Weather()
        {
            string temp, humidity, wind;
            using (WebClient web = new WebClient())
            {
                string url = string.Format(@"https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", location, apiKey);
                var json = web.DownloadString(url);
                Weather_DTO.Info info = JsonConvert.DeserializeObject<Weather_DTO.Info>(json);
                temp = info.Main.Temp.ToString();
                humidity = info.Main.Humidity.ToString();
                wind = info.Wind.Speed.ToString();
                var tuple = new Tuple<string, string, string>(temp, humidity, wind);
                return tuple;
            }
        }
    }
}
