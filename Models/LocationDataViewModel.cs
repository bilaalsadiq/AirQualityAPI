using System;
using System.Collections.Generic;


namespace AirQualityAPI.Models
{
    public class RootObject
    {
        public Meta meta { get; set; }
        public List<Result> results { get; set; }
    }

    public class Meta
    {
        public string name { get; set; }
        public string license { get; set; }
        public string website { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int found { get; set; }
    }

    public class Source
    {
        public string id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Parameter
    {
        public int id { get; set; }
        public string unit { get; set; }
        public int count { get; set; }
        public double average { get; set; }
        public double lastValue { get; set; }
        public string parameter { get; set; }
        public string displayName { get; set; }
        public DateTime lastUpdated { get; set; }
        public int parameterId { get; set; }
        public DateTime firstUpdated { get; set; }
    }

    public class Coordinates
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string city { get; set; }
        public string name { get; set; }
        public string entity { get; set; }
        public string country { get; set; }
        public List<Source> sources { get; set; }
        public bool isMobile { get; set; }
        public bool isAnalysis { get; set; }
        public List<Parameter> parameters { get; set; }
        public string sensorType { get; set; }
        public Coordinates coordinates { get; set; }
        public DateTime lastUpdated { get; set; }
        public DateTime firstUpdated { get; set; }
        public int measurements { get; set; }
    }

  
}

