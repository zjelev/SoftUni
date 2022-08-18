using System.Text.Json;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;

namespace JsonDemo
{
    class Forecasts
    {
        public Tuple<int, string> AdditionalData { get; set; } = null!;
        public List<WeatherForecast> Forecast { get; set; } = null!;
    }

    class WeatherForecast
    {
        [JsonIgnore] // EF = NotMapped
        public DateTime Date { get; set; } = DateTime.Now;
        [JsonPropertyName("During the day")]
        [JsonPropertyOrder(1)]

        public List<int> TemperaturesC { get; set; } = new List<int> { 30, 29, 27 };

        [JsonPropertyOrder(0)]
        [JsonInclude]
        public string Summary { get; set; } = "Hot summer day";
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            var forecast = new Forecasts
            {
                AdditionalData = new Tuple<int, string>(132, "Miki"),
                Forecast = new List<WeatherForecast> { new WeatherForecast(), new WeatherForecast(), new WeatherForecast() }
            };

            var weather = new WeatherForecast();

            var obj = new { TemperaturesC = 0, Summary = string.Empty };

            var json = System.Text.Json.JsonSerializer.Serialize(forecast, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllTextAsync("forecast.json", json);
            var jsonFile = File.ReadAllText("weather.json");
            var forecastJ = System.Text.Json.JsonSerializer.Deserialize<Forecasts>(jsonFile);
            var token = JsonSerializerExtensions.DeserializeAnonymousType(jsonFile, obj);
            //obj = JsonConvert.DeserializeAnonymousType(jsonFile, obj);

            
        }
    }

    public static partial class JsonSerializerExtensions
    {
        public static T? DeserializeAnonymousType<T>(string json, T anonymousTypeObject, JsonSerializerOptions? options = default)
            => System.Text.Json.JsonSerializer.Deserialize<T>(json, options);

        public static ValueTask<TValue?> DeserializeAnonymousTypeAsync<TValue>(Stream stream, TValue anonymousTypeObject, JsonSerializerOptions? options = default, CancellationToken cancellationToken = default)
            => System.Text.Json.JsonSerializer.DeserializeAsync<TValue>(stream, options, cancellationToken); // Method to deserialize from a stream added for completeness
    }
}
