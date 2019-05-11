using System.Collections.Generic;
using FinalWeatherData.DarkSky.Enum;

namespace FinalWeatherData.DarkSky
{
    public class DataBlock<T>
    {
        public DataBlock()
        {
            
        }
        /// <summary>
        /// Required
        /// An array of data points, ordered by time, which together describe the weather conditions at the requested location over time.
        /// </summary>
        public List<T> Data { get; set; }

        /// <summary>
        /// Optional
        /// A human-readable summary of this data block.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Optional
        /// A machine-readable text summary of this data block. (May take on the same values as the iconproperty of data points.)
        /// </summary>
        public Icon Icon { get; set; }

        
        
    }
}
