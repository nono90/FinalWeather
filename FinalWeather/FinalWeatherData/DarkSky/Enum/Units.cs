using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeatherData.DarkSky.Enum
{
    public enum Units
    {
        /// <summary>
        /// automatically select units based on geographic location
        /// </summary>
        auto,

        /// <summary>
        /// same as si, except that windSpeed and windGust are in kilometers per hour
        /// </summary>
        ca,

        /// <summary>
        /// same as si, except that nearestStormDistance and visibility are in miles, and windSpeed and windGust in miles per hour
        /// </summary>
        uk2,

        /// <summary>
        /// Imperial units (the default)
        /// </summary>
        us,

        /// <summary>
        /// SI units
        /// </summary>
        si
    }
}
