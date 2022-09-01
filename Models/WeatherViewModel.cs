using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWeather202208.Models
{
    //参考サイト→https://manojbkalla.weebly.com/
    public class ResultViewModel 
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; } //緯度
        public string Lon { get; set; } //経度=Longitude=Lon
        public string Description { get; set; } //概要
        public string Humiditu { get; set; } //湿度
        public string TempFeelsLike { get; set; } //体感温度
        public string Temp { get; set; } //気温
        public string TempMax { get; set; } //最高気温 
        public string TempMin { get; set; } //最低気温
        public string WeatherIcon { get; set; } //
    } //class WeatherViewModel終端

    public class Coord 
    {
        public double Lat { get; set; }

        public double Lon { get; set; }

    }  //class Coord終端

    public class Weather 
    {
        public int id { get; set; }
        public int main { get; set; }
        public int description { get; set; }
        public int icon { get; set; }
    } //class Weather終端

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int temp_min { get; set; }
        public int temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    } //class Main終端

    public class Wind 
    {
        public double speed { get; set; }
        public int deg { get; set; }
    } //class Wind終端

    public class Clouds
    {
        public double speed { get; set; }
        public int deg { get; set; }
    } //class Clouds終端

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    } //class Sys終端

    public class RootObject
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    } //RootObject終端
}
