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
        Auto,

        /// <summary>
        /// same as si, except that windSpeed and windGust are in kilometers per hour
        /// </summary>
        Ca,

        /// <summary>
        /// same as si, except that nearestStormDistance and visibility are in miles, and windSpeed and windGust in miles per hour
        /// </summary>
        Uk2,

        /// <summary>
        /// Imperial units (the default)
        /// </summary>
        Us,

        /// <summary>
        /// SI units
        /// </summary>
        Si
    }
}
