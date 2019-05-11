namespace FinalWeatherData.DarkSky
{
    public class Connection
    {
        public Connection()
        {
            
        }

        private const string Uri = "https://api.darksky.net/forecast/";
        private const string Key = "5f5148d38811494d79a9b3a7dc46f4fd";


        private string GetUri()
        {
            return $"{Uri}{Key}/";
        }

        public string GetUri(Location location)
        {
            return $"{GetUri()}{location.Latitude.ToString().Replace(",", ".")},{location.Longitude.ToString().Replace(",",".")}";
        }
    }
}
