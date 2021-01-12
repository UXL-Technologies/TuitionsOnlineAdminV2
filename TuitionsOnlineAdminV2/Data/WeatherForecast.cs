using System;

namespace TuitionsOnlineAdminV2.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Forecast { get; set; }
        //Authors: Thanvi &Vandith date : 11-01-2021
        //for testing data grid 
        public bool Active { get; set; }
        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);
    }
}

