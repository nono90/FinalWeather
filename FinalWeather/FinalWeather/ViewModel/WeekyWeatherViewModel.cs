using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FinalWeather.Annotations;
using FinalWeatherData.DarkSky.DataPoint;

namespace FinalWeather.ViewModel
{
    public class WeekyWeatherViewModel
    {
        private List<DailyWeatherSummaryViewModel> _dailyViewModels;

        public List<DailyWeatherSummaryViewModel> DailyViewModels
        {
            get => _dailyViewModels;
            set
            {
                _dailyViewModels = value;
            }
        }
        public WeekyWeatherViewModel()
        {
            
        }

        public WeekyWeatherViewModel(List<Daily> dailys)
        {
            var dailyViewModels = new List<DailyWeatherSummaryViewModel>();
            foreach (var daily in dailys.Where(d => d.Date >= DateTime.Today))
            {
                dailyViewModels.Add(new DailyWeatherSummaryViewModel(daily));
            }
            _dailyViewModels = dailyViewModels;
        }
    }
}
