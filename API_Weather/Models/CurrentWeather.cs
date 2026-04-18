using System.Text.Json.Serialization;
namespace API_Weather.Models
{
    public class CurrentWeather
    {
        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }

        [JsonPropertyName("windspeed")]
        public double Windspeed { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }
}
