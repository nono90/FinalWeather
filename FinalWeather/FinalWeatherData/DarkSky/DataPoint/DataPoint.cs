using System;
using FinalWeatherData.DarkSky.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FinalWeatherData.DarkSky.DataPoint
{
    public class DataPoint
    {
        public DataPoint()
        {
            
        }
        /// <summary>
        /// Optional
        /// The percentage of sky occluded by clouds, between 0 and 1, inclusive.
        /// </summary>
        public decimal? CloudCover{ get; set; }

        /// <summary>
        /// Optional
        /// The dew point in degrees Fahrenheit.
        /// </summary>
        public decimal? DewPoint { get; set; }

        /// <summary>
        /// Optional
        /// The relative humidity, between 0 and 1, inclusive.
        /// </summary>
        public decimal? Humidity { get; set; }

        /// <summary>
        /// Optional
        /// A machine-readable text summary of this data point, suitable for selecting an icon for display.
        /// If defined, this property will have one of the following values:
        /// clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, or partly-cloudy-night.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Icon? Icon { get; set; }

        /// <summary>
        /// Optional
        /// The columnar density of total atmospheric ozone at the given time in Dobson units.
        /// </summary>
        public decimal? Ozone { get; set; }

        /// <summary>
        /// Optional
        /// The intensity (in inches of liquid water per hour) of precipitation occurring at the given time.This value is conditional on probability(that is, assuming any precipitation occurs at all).
        /// </summary>
        public decimal PrecipIntensity { get; set; }

        /// <summary>
        /// Optional
        /// The standard deviation of the distribution of precipIntensity. (We only return this property when the full distribution, and not merely the expected mean, can be estimated with accuracy.)
        /// </summary>
        public decimal? PrecipIntensityError { get; set; }

        /// <summary>
        /// Optional
        /// The probability of precipitation occurring, between 0 and 1, inclusive.
        /// </summary>
        public decimal? PrecipProbability { get; set; }
        
        /// <summary>
        /// Optional
        /// The type of precipitation occurring at the given time.
        /// If defined, this property will have one of the following values: "rain", "snow", or "sleet" (which refers to each of freezing rain, ice pellets, and “wintery mix”).
        /// (If precipIntensity is zero, then this property will not be defined.Additionally, due to the lack of data in our sources, historical precipType information is usually estimated, rather than observed.)
        /// </summary>
        public PrecipType? PrecipType { get; set; }
        
        /// <summary>
        /// Optional
        /// The sea-level air pressure in millibars.
        /// </summary>
        public decimal? Pressure { get; set; }

        /// <summary>
        /// Optional
        /// A human-readable text summary of this data point.
        /// (This property has millions of possible values, so don’t use it for automated purposes: use the icon property, instead!)
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Required
        /// The UNIX time at which this data point begins.
        /// minutely data point are always aligned to the top of the minute, hourly data point objects to the top of the hour, and daily data point objects to midnight of the day, all according to the local time zone.
        /// </summary>
        public string Time { get; set; }
       
        public DateTime? Date
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Time)
                    || !long.TryParse(Time, out long tmpTime))
                {
                    return null;
                }
                return DateTimeOffset.FromUnixTimeSeconds(tmpTime).DateTime;
            }
        }
        
        /// <summary>
        /// Optional
        /// The UV index.
        /// </summary>
        public decimal? UvIndex { get; set; }

        /// <summary>
        /// Optional
        /// The average visibility in miles, capped at 10 miles.
        /// </summary>
        public decimal? Visibility { get; set; }
        
        /// <summary>
        /// Optional
        /// The direction that the wind is coming from in degrees, with true north at 0° and progressing clockwise.
        /// (If windSpeed is zero, then this value will not be defined.)
        /// </summary>
        public decimal? WindBearing { get; set; }


        /// <summary>
        /// Optional
        /// The wind gust speed in miles per hour.
        /// </summary>
        public decimal? WindGust { get; set; }
        
        /// <summary>
        /// Optional
        /// The wind speed in miles per hour.
        /// </summary>
        public decimal? WindSpeed { get; set; }
    }
}
