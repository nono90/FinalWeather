namespace FinalWeatherData.DarkSky.DataPoint
{
    public class Currently : DataPoint
    {
        public Currently(): base()
        {
            
        }

        /// <summary>
        /// optional, only on currently
        /// The approximate direction of the nearest storm in degrees, with true north at 0° and progressing clockwise. (If nearestStormDistance is zero, then this value will not be defined.)
        /// </summary>
        public decimal? NearestStormBearing { get; set; }
            
        /// <summary>
        /// optional, only on currently
        /// The approximate distance to the nearest storm in miles. (A storm distance of 0 doesn’t necessarily refer to a storm at the requested location, but rather a storm in the vicinity of that location.)
        /// </summary>
        public decimal? NearestStormDistance { get; set; }
    }
}
