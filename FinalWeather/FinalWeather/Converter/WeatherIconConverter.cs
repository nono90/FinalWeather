using System;
using Windows.UI.Xaml.Data;
using FinalWeatherData.DarkSky.Enum;

namespace FinalWeather.Converter
{
    public class WeatherIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null
                || !(value is Icon tmpIcon))
            {
                return null;
            }
            
            switch (tmpIcon)
            {
                case Icon.ClearDay:
                    return "../Ressources/sun.png";
                case Icon.ClearNight:
                    return "../Ressources/moon.png";
                case Icon.Cloudy:
                    return "../Ressources/cloud.png";
                case Icon.Rain:
                    return "../Ressources/rain.png";
                case Icon.Snow:
                    return "../Ressources/snowflake.png";
                case Icon.Sleet:
                    return "../Ressources/sun_simle_cloudy_snow.png";
                case Icon.Wind:
                    return "../Ressources/wind.png";
                case Icon.Fog:
                    return "../Ressources/fog.png";
                case Icon.PartlyCloudyDay:
                    return "../Ressources/sun_simple_cloudy.png";
                case Icon.PartlyCloudyNight:
                    return "../Ressources/moon_cloudy.png";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
