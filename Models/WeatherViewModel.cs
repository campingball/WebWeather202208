﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWeather202208.Models
{
    public class WeatherViewModel //参考サイト→https://manojbkalla.weebly.com/ではResultViewModelクラスと書いてあるが？
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Description { get; set; }
        public string Humiditu { get; set; }
    }
}
