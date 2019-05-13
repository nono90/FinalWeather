using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FinalWeather.DarkSkyDatatAccess;
using FinalWeatherData;
using FinalWeatherData.DarkSky;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace FinalWeatherUnitTest
{
    [TestClass]
    public class WebserviceUnitTest
    {
        private string url = "https://api.darksky.net/forecast/5f5148d38811494d79a9b3a7dc46f4fd/";
        private Location _locationLyon = new Location
        {
             Latitude = 45.75m,
             Longitude = 4.85m
        };

        private Location _locationBelfort = new Location()
        {
            Latitude = 47.6333m,
            Longitude = 6.8667m
        };

        [TestMethod]
        public async void WebServiceConnexion()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{url}{_locationLyon.Latitude.ToString().Replace(",",".")},{_locationLyon.Longitude.ToString().Replace(",", ".")}");

                Assert.IsTrue(response.IsSuccessStatusCode);

                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Reponse>(responseBody);
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void DataAccessLoading()
        {
            var dataAccess = new DarkSkyConnection();
            Dictionary<Location, Reponse> result = dataAccess.Initialise(_locationLyon).LoadData().Result();

            Assert.IsTrue(result.ContainsKey(_locationLyon));

            Assert.IsNotNull(result[_locationLyon]);
        }

        [TestMethod]
        public void DataAccessLoadingLocationList()
        {
            var dataAccess = new DarkSkyConnection();
            Dictionary<Location, Reponse> result = dataAccess
                .Initialise(new List<Location>
                {
                    _locationLyon,
                    _locationBelfort
                })
                .LoadData()
                .Result();

            Assert.IsTrue(result.ContainsKey(_locationLyon));
            Assert.IsNotNull(result[_locationLyon]);

            Assert.IsTrue(result.ContainsKey(_locationBelfort));
            Assert.IsNotNull(result[_locationBelfort]);
        }

    }
}
