using System.Collections.Generic;
using Windows.Data.Json;
using Newtonsoft.Json;

namespace FinalWeatherData.DarkSky
{
    public class Flag
    {
        public Flag()
        {
            
        }

        /// <summary>
        /// optional
        /// The presence of this property indicates that the Dark Sky data source supports the given location, but a temporary error (such as a radar station being down for maintenance) has made the data unavailable.
        /// </summary>
        [JsonProperty(PropertyName = "Darksky-Unavailable")]
        public bool? DarkskyUnavailable { get; set; }

        /// <summary>
        /// required
        /// The distance to the nearest weather station that contributed data to this response. Note, however, that many other stations may have also been used; this value is primarily for debugging purposes. This property's value is in miles (if US units are selected) or kilometers (if SI units are selected).
        /// </summary>
        [JsonProperty(PropertyName = "Nearest-Station")]
        public decimal NearestStation { get; set; } 
        
        /// <summary>
        /// required
        /// This property contains an array of IDs for each data source utilized in servicing this request.
        /// </summary>
        public List<string> Sources { get; set; }
        
        /// <summary>
        /// required
        /// Indicates the units which were used for the data in this request.
        /// </summary>
        public string Units { get; set; }
    }
}
