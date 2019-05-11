using System;

namespace FinalWeatherData.DarkSky.DataPoint
{
    public class Daily : Accumulation
    {
        public Daily() : base()
        {
            
        }

        /// <summary>
        /// optional, only on daily
        /// The daytime high apparent temperature.
        /// </summary>
        public decimal? ApparentTemperatureHigh { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the daytime high apparent temperature occurs.
        /// </summary>
        public string ApparentTemperatureHighTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The overnight low apparent temperature.
        /// </summary>
        public decimal? ApparentTemperatureLow { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the overnight low apparent temperature occurs.
        /// </summary>
        public string ApparentTemperatureLowTime { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The maximum apparent temperature during a given date.
        /// </summary>
        public decimal? ApparentTemperatureMax { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the maximum apparent temperature during a given date occurs.
        /// </summary>
        public string ApparentTemperatureMaxTime { get; set; }
            
        /// <summary>
        /// optional, only on daily
        /// The minimum apparent temperature during a given date.
        /// </summary>
        public decimal? ApparentTemperatureMin { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the minimum apparent temperature during a given date occurs.
        /// </summary>
        public string ApparentTemperatureMinTime { get; set; }

        /// <summary>
        /// optional, only on daily
        /// The fractional part of the lunation number during the given day: a value of 0 corresponds to a new moon, 0.25 to a first quarter moon, 0.5 to a full moon, and 0.75 to a last quarter moon. (The ranges in between these represent waxing crescent, waxing gibbous, waning gibbous, and waning crescent moons, respectively.)
        /// </summary>
        public decimal? MoonPhase { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The maximum value of precipIntensity during a given day.
        /// </summary>
        public decimal? PrecipIntensityMax { get; set; }

        /// <summary>
        /// optional, only on daily
        /// The UNIX time of when precipIntensityMax occurs during a given day.
        /// </summary>
        public string PrecipIntensityMaxTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time of when the sun will rise during a given day.
        /// </summary>
        public string SunriseTime { get; set; }  
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time of when the sun will set during a given day.
        /// </summary>
        public string SunsetTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The daytime high temperature.
        /// </summary>
        public decimal? TemperatureHigh { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the daytime high temperature occurs.
        /// </summary>
        public decimal? TemperatureHighTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The overnight low temperature.
        /// </summary>
        public decimal? TemperatureLow { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the overnight low temperature occurs.
        /// </summary>
        public string TemperatureLowTime { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The maximum temperature during a given date.
        /// </summary>
        public decimal? TemperatureMax { get; set; }

        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the maximum temperature during a given date occurs.
        /// </summary>
        public string TemperatureMaxTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The minimum temperature during a given date.
        /// </summary>
        public decimal? TemperatureMin { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time representing when the minimum temperature during a given date occurs.
        /// </summary>
        public string TemperatureMinTime { get; set; }
    
        /// <summary>
        /// optional, only on daily
        /// The UNIX time of when the maximum uvIndex occurs during a given day.
        /// </summary>
        public string UvIndexTime { get; set; }
        
        /// <summary>
        /// optional, only on daily
        /// The time at which the maximum wind gust speed occurs during the day.
        /// </summary>
        public string DateTime { get; set; }
    }
}
