using System;
using System.Collections.Generic;
using System.Linq;
using TuitionsOnlineAdminV2.Data;

public class WeatherForecastService {
    private List<WeatherForecast> Forecasts { get; set; }

    public WeatherForecastService() {
        Forecasts = CreateForecast();
    }

    public IEnumerable<WeatherForecast> GetForecast() {

        return Forecasts;
    }
    //Authors: Thanvi &Vandith date : 11-01-2021
    //for testing data grid 
    private List<WeatherForecast> CreateForecast() {
        var rng = new Random();;
        DateTime startDate = DateTime.Now;

        int min = 0;
        int max = 0;
        int? temperatureC = null;

        return Enumerable.Range(1, 15).Select(index => {
            var day = startDate.AddDays(index);
            if(day.Month - startDate.AddDays(index - 1).Month != 0 || temperatureC == null) {
                min = temperatureStatistic[day.Month - 1].Item1;
                max = temperatureStatistic[day.Month - 1].Item2;
                temperatureC = rng.Next(min, max);
            } else {
                temperatureC = temperatureC + rng.Next(-3, 3);
                temperatureC = Math.Max(temperatureC.Value, min);
                temperatureC = Math.Min(temperatureC.Value, max);
            }
            int weatherTypes = rng.NextDouble() < 0.5 ? 0 : (rng.NextDouble() < 0.5 ? 1 : rng.NextDouble() < 0.5 ? 2 : 3);
            double feelTemper = temperatureC.Value - (weatherTypes - 1) * 3;
            return new WeatherForecast {
                Date = day,
                Active = true,
                TemperatureC = temperatureC.Value,
                Forecast = ConditionsForForecast.First(c => c.Item1 <= feelTemper).Item2
            };
        }).ToList();
    }

    Tuple<int, int>[] temperatureStatistic = new Tuple<int, int>[] {
        Tuple.Create(-15, -1),
        Tuple.Create(-12, -2),
        Tuple.Create(-6, 8),
        Tuple.Create(4, 14),
        Tuple.Create(11, 21),
        Tuple.Create(13, 23),
        Tuple.Create(18, 32),
        Tuple.Create(16, 26),
        Tuple.Create(10, 18),
        Tuple.Create(1, 11),
        Tuple.Create(-4, 6),
        Tuple.Create(-13, 1)
    };

    Tuple<int, string>[] ConditionsForForecast = new Tuple<int, string>[] {
        Tuple.Create( 28 , "Hot"),
        Tuple.Create(14, "Warm"),
        Tuple.Create(-9, "Cold"),
        Tuple.Create(-80, "Freezing")
    };

   
}