﻿using System;

// A general class that is used to hold data and strctures for examples.
// Defines so that examples can interchange data & ideas
// 
// Files for CSV, XML, JSON, TEXT, ... and memory DataTables, database tables, 
// spreadsheets etc, Web pages, API, MVC, ADO etc 

namespace Conductus.Widget.Object
{
    // Instance Examples (psate into your code)

    // Tuple assigned values

    // static Widget m_widget1 = new Widget()
    // {
    //    Date = DateTimeOffset.Now,
    //    TemperatureC = 32,
    //    Summary = "Test 1 summary"
    // };

    // Empty values

    // An empty destination object
    // static Widget m_widget2 = new Widget();

    // Constructor assigned values 

    // static Widget m_widget3 = new Widget(DateTimeOffset.Now, 32, "Summary3");

    // https://www.w3schools.com/cs/cs_constructors.asp

    public class WidgetObject
    {
        // Default (optional) initialise to known good values
        public WidgetObject()
        {
            Date = DateTimeOffset.MinValue;
            TemperatureC = int.MinValue;
            Summary = string.Empty;
            Secret = string.Empty;
        }
        // Create a class constructor with multiple parameters
        public WidgetObject(DateTimeOffset date, int temperatureC, string summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
        public WidgetObject(DateTimeOffset date, int temperatureC, string summary, string secret)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
            Secret = secret;
        }
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); // calculated
        public string Summary { get; set; }
        public string Secret { get; set; } // not included in DTO version of class.
    }
}
