using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.UI.Xaml;
using FinalWeatherData.DarkSky.DataPoint;
using FinalWeatherData.DarkSky.Enum;

namespace FinalWeather.ViewModel
{
    public class DailyWeatherSummaryViewModel
    {
        private Daily _dailyWeatherInformation = new Daily();

        public DailyWeatherSummaryViewModel()
        {
            
        }
        public DailyWeatherSummaryViewModel(Daily daily)
        {
            _dailyWeatherInformation = daily;
        }

        public string TemperatureMaxDisplay => $"{_dailyWeatherInformation.TemperatureMax ?? _dailyWeatherInformation.TemperatureHigh} °C";

        public string TemperatureMinDisplay => $"{_dailyWeatherInformation.TemperatureMin ?? _dailyWeatherInformation.TemperatureLow} °C";

        public Icon IconDisplay => _dailyWeatherInformation.Icon ?? Icon.ClearDay;

        public string DateTimeDisplay => $"{_dailyWeatherInformation.Date?.DayOfWeek} {_dailyWeatherInformation.Date?.Day}/{_dailyWeatherInformation.Date?.Month}";
    }
}
