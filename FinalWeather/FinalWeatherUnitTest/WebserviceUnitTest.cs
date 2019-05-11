using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;
using FinalWeatherData;
using FinalWeatherData.DarkSky;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace FinalWeatherUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task WebServiceConnexion()
        {
            var locationLyon = new Location
            {
                Longitude = 45.75m,
                Latitude = 4.85m
            };
            var connectionApi = new Connection();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(connectionApi.GetUri(locationLyon));

                Assert.IsTrue(response.IsSuccessStatusCode);

                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Reponse>(responseBody);
                Assert.IsNotNull(result);
            }
        }
        
    }
}
