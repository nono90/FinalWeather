namespace FinalWeatherData.DarkSky.DataPoint
{
    public class Hourly : Accumulation
    {
        public Hourly(): base()
        {

        }

        /// <summary>
        /// optional, only on hourly
        /// The apparent(or “feels like”) temperature in degrees Fahrenheit.
        /// </summary>
        public decimal? ApparentTemperature { get; set; }
        
        /// <summary>
        /// optional, only on hourly
        /// The air temperature in degrees Fahrenheit.
        /// </summary>
        public decimal? Temperature { get; set; }
    }
}
