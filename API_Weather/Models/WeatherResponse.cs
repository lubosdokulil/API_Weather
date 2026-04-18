using System.Text.Json.Serialization;
namespace API_Weather.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("current_weather")]
        public CurrentWeather CurrentWeather { get; set; }
    }
}
