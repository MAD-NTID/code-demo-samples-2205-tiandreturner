using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MADWeather
{
    class WeatherClassProxy
    {
        //USE YOUR KEY HERE
        private static string apiKey = "YOUR KEY HERE";

        public async static Task<Root> GetWeather(double lat, double lon)
        {
            //Use this whenever you are accessing data from the Web
            HttpClient client = new HttpClient();
            //Check to make sure we get a response, a success-ful response
            var response = await client.GetAsync(String.Format($"http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=imperial"));
            //If response is good, let's grab the result.  The result will be serialized data from openweathermap.org
            var result = await response.Content.ReadAsStringAsync();

            Root myDeserializedData = JsonConvert.DeserializeObject<Root>(result);
            return myDeserializedData;
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Coord
        {
            [JsonProperty("lon")]
            public double Lon { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }
        }

        public class Weather
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public class Main
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("feels_like")]
            public double FeelsLike { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }

            [JsonProperty("pressure")]
            public int Pressure { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }
        }

        public class Wind
        {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public int Deg { get; set; }
        }

        public class Clouds
        {
            [JsonProperty("all")]
            public int All { get; set; }
        }

        public class Sys
        {
            [JsonProperty("type")]
            public int Type { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("sunrise")]
            public int Sunrise { get; set; }

            [JsonProperty("sunset")]
            public int Sunset { get; set; }
        }

        public class Root
        {
            [JsonProperty("coord")]
            public Coord Coord { get; set; }

            [JsonProperty("weather")]
            public List<Weather> Weather { get; set; }

            [JsonProperty("base")]
            public string Base { get; set; }

            [JsonProperty("main")]
            public Main Main { get; set; }

            [JsonProperty("visibility")]
            public int Visibility { get; set; }

            [JsonProperty("wind")]
            public Wind Wind { get; set; }

            [JsonProperty("clouds")]
            public Clouds Clouds { get; set; }

            [JsonProperty("dt")]
            public int Dt { get; set; }

            [JsonProperty("sys")]
            public Sys Sys { get; set; }

            [JsonProperty("timezone")]
            public int Timezone { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("cod")]
            public int Cod { get; set; }
        }




    }
}
