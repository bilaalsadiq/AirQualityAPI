using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace AirQualityAPI.Models
{
    public class City
    {
        public object getCityData()
        {
            string url = "https://docs.openaq.org/v2/latest?limit=100&page=1&offset=0&sort=desc&radius=1000&country=GB&city=Manchester&order_by=lastUpdated&dumpRaw=false";

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