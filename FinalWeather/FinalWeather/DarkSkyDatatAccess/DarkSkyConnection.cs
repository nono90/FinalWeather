using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FinalWeatherData;
using FinalWeatherData.DarkSky;
using FinalWeatherData.DarkSky.Enum;
using Newtonsoft.Json;

namespace FinalWeather.DarkSkyDatatAccess
{
    public class DarkSkyConnection
    {
        private const string BaseUri = "https://api.darksky.net/forecast/";
        private const string Key = "5f5148d38811494d79a9b3a7dc46f4fd";

        private readonly List<ExcludeBlock> _excludeBlocks = new List<ExcludeBlock>
        {
            ExcludeBlock.minutely,
            ExcludeBlock.hourly,
            ExcludeBlock.alerts,
            ExcludeBlock.flags
        };

        private readonly Dictionary<Location, Reponse> _weatherInformations = new Dictionary<Location, Reponse>();
        private string _uri => $"{BaseUri}{Key}";

        public DarkSkyConnection Initialise(Location location)
        {
            if (_weatherInformations.ContainsKey(location)) return this;
            _weatherInformations.Add(location, null);
            return this;
        }

        public DarkSkyConnection Initialise(List<Location> locations)
        {
            locations.ForEach(l => Initialise(l));
            return this;
        }

        public DarkSkyConnection LoadData()
        {
            if (_weatherInformations.Count == 0) return this;
            
            foreach (var location in _weatherInformations.Keys.ToList())
            {
                _weatherInformations[location] = LoadAsync(location).Result;
            }
            return this;
        }

        private async Task<Reponse> LoadAsync(Location location)
        {
            Reponse tmpReponse;
            
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(new Uri(GetFullUri(location)), HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var responseBody = await response.Content.ReadAsStringAsync();
                tmpReponse = await JsonConvert.DeserializeObjectAsync<Reponse>(responseBody);
            }
            return tmpReponse;
        }

        private string GetFullUri(Location location)
        {
            return $"{_uri}/{GetLocationUri(location)}{GetUnits()}{GetExcludedBlocks()}";
        }

        private string GetUnits()
        {
            return $"?units={Units.si}";
        }

        private string GetExcludedBlocks()
        {
            var tmp = "&exclude=";
            _excludeBlocks.ForEach(b => tmp += $"{b},");
            return tmp.Substring(0, tmp.Length - 1);
        }

        private string GetLocationUri(Location location)
        {
            return
                $"{location.Latitude.ToString().Replace(",", ".")},{location.Longitude.ToString().Replace(",", ".")}";
        }

        public Dictionary<Location, Reponse> Result()
        {
            return _weatherInformations;
        }
    }
}