using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace AirQualityAPI.Models
{
    public class Country
    {
        public object LoadCountries()
        {
            string url = "https://docs.openaq.org/v2/countries?limit=200&page=1&offset=0&sort=asc&order_by=country";

            //synchronous client
            var client = new WebClient();
            //return JSON content from URL as a string, into the content variable
            var content = client.DownloadString(url);
            //create serialiser - needed to deserialise JSON data
            var serializer = new JavaScriptSerializer();

            var jsonContent = serializer.Deserialize<object>(content);
            return jsonContent;
        }
    }
}