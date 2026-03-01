namespace API_Weather.Models
{
    public class WeatherResponse
    {
        // Tato vlastnost se musí jmenovat přesně jako v JSONu
        public CurrentWeather current_weather { get; set; }
    }
}
