using System;

// A general class that is used to hold data and strctures for examples.
// Defines so that examples can interchange data & ideas
// 
// Files for CSV, XML, JSON, TEXT, ... and memory DataTables, database tables, 
// spreadsheets etc, Web pages, API, MVC, ADO etc 

namespace Conductus.Widget.Object.Net
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

    public class WidgetDTO
    {
        // Default (optional) do nothing
        public WidgetDTO()
        {
        }
        // Create class constructors with multiple parameters
        public WidgetDTO(DateTimeOffset date)
        {
            Date = date;
        }
        public WidgetDTO(WidgetObject widget)
        {
            Id = widget.Id;
            Date = widget.Date;
            Name = widget.Name;
            Count = widget.Count;
        }
        public WidgetDTO WidgetToDTO(WidgetObject widget) => new WidgetDTO (widget);
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
