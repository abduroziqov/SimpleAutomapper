using AutoMapper;
using SimpleAutomapper.ViewModel;

namespace SimpleAutomapper.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastViewModel>();
           // CreateMap<WeatherForecast,  WeatherForecast>().ReverseMap();
        }
    }
}
