﻿
using Observer.Observers;
using Observer.Subjects;

WeatherData weatherData = new WeatherData();

CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);


Console.ReadLine();
