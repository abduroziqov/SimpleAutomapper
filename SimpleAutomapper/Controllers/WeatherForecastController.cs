using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleAutomapper.ViewModel;

namespace SimpleAutomapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastViewModel> Get()
        {
            var weatherForecast = Enumerable.Range(1, 5)
                .Select(index =>
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = new Random().Next(-20, 55),
                    Summary = Summaries[new Random().Next(Summaries.Length)]
                }).ToList();

            return _mapper.Map<List<WeatherForecastViewModel>>(weatherForecast);
        }
    }
}