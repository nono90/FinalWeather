using System.Collections.Generic;
using FinalWeatherData.DarkSky;
using FinalWeatherData.DarkSky.DataPoint;

namespace FinalWeatherData.DarkSky
{
    public class Reponse : Location
    {
        public Reponse()
        {
            
        }

        /// <summary>
        /// Required
        /// (e.g.America/New_York)
        /// The IANA timezone name for the requested location.This is used for text summaries and for determining when hourly and daily data block objects begin.
        /// </summary>
        public string Timezone { get; set; }
            
        /// <summary>
        /// Optional
        /// A data point containing the current weather conditions at the requested location.
        /// </summary>
        public Currently Currently { get; set; }
        
        /// <summary>
        /// Required
        /// A data block containing the weather conditions minute-by-minute for the next hour.
        /// </summary>
        public DataBlock<DataPoint.DataPoint> Minutely { get; set; }
        
        /// <summary>
        /// Optional
        /// A data block containing the weather conditions hour-by-hour for the next two days.
        /// </summary>
        public DataBlock<Hourly> Hourly { get; set; }
    
        /// <summary>
        /// Optional
        /// A data block containing the weather conditions day-by-day for the next week.
        /// </summary>
        public DataBlock<Daily> Daily { get; set; }

        /// <summary>
        /// Optional
        /// An alerts array, which, if present, contains any severe weather alerts pertinent to the requested location.
        /// </summary>
        public List<Alert> Alerts { get; set; }

        /// <summary>
        /// Optional
        /// A flags object containing miscellaneous metadata about the request.
        /// </summary>
        public Flag Flags { get; set; } 
            
    }
}
