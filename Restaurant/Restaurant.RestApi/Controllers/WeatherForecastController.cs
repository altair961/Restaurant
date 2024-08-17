using Microsoft.AspNetCore.Mvc;

namespace Restaurant.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController() : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //String MYVAR = "ttt";
            var rand = new Random();
            return Enumerable.Range(1, 5).Select(static index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = -20,
                Summary = Summaries[3]
            })
            .ToArray();
        }
    }
}
