namespace FinalWeatherData.DarkSky.DataPoint
{
    public class Accumulation : DataPoint
    {
        public Accumulation() : base()
        {
            
        }

        /// <summary>
        /// Optional, only on hourly and daily
        /// The amount of snowfall accumulation expected to occur, in inches. (If no snowfall is expected, this property will not be defined.)
        /// </summary>
        public decimal? PrecipAccumulation { get; set; }
    }
}
