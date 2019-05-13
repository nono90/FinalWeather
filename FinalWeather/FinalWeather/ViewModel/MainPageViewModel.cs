using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using FinalWeather.Annotations;
using FinalWeather.DarkSkyDatatAccess;
using FinalWeatherData;
using FinalWeatherData.DarkSky;
using FinalWeatherData.DarkSky.DataPoint;

namespace FinalWeather.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private DarkSkyConnection _darkSkyConnection = new DarkSkyConnection();
        private Location _locationBelfort = new Location()
        {
            Latitude = 47.6333m,
            Longitude = 6.8667m
        };

        public WeekyWeatherViewModel _weeklyViewModel;
        public WeekyWeatherViewModel WeeklyViewModel
        {
            get => _weeklyViewModel;
            set
            {
                _weeklyViewModel = value;
                OnPropertyChanged("WeeklyViewModel");
            }
        }

        public MainPageViewModel()
        {
            InitializeWeather();
        }
        
        private void InitializeWeather()
        {
            WeeklyViewModel = new WeekyWeatherViewModel(_darkSkyConnection.Initialise(_locationBelfort).LoadData().Result()[_locationBelfort].Daily.Data);
        }

        public async Task Refresh()
        {
            InitializeWeather();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
