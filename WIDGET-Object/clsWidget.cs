using System;

// A general class that is used to hold data and strctures for examples.
// Defines so that examples can interchange data & ideas
// 
// Files for CSV, XML, JSON, TEXT, ... and memory DataTables, database tables, 
// spreadsheets etc, Web pages, API, MVC, ADO etc 

namespace Conductus.Widget.Object.NET
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
            Name = string.Empty;
            Count = 0;
            Secret = string.Empty;
        }
        // Createclass constructors with multiple parameters
        public WidgetObject(DateTimeOffset date)
        {
            Date = date;
        }
        public WidgetObject(DateTimeOffset date, string secret)
        {
            Date = date;
            Secret = secret;
        }
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Secret { get; set; } // not included in DTO version of class.
    }
}
