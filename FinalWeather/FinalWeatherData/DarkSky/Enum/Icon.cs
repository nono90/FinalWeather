using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeatherData.DarkSky.Enum
{
    public enum Icon
    {
        [EnumMember(Value = "clear-day")]
        ClearDay,
        [EnumMember(Value = "clear-night")]
        ClearNight,
        Rain,
        Snow,
        Sleet,
        Wind,
        Fog,
        Cloudy,
        [EnumMember(Value = "partly-cloudy-day")]
        PartlyCloudyDay,
        [EnumMember(Value = "partly-cloudy-night")]
        PartlyCloudyNight
    }
}
