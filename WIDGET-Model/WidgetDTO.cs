using System;
using Newtonsoft.Json;

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
    public WidgetDTO(Widget widget)
    {
        Id = widget.Id;
        Date = widget.Date;
        Name = widget.Name;
        Count = widget.Count;
    }
    public WidgetDTO WidgetToDTO(Widget widget) => new WidgetDTO(widget);
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("date")]
    public DateTimeOffset Date { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("count")]
    public int Count { get; set; }
    public string Display(string title)
    {
        string s = string.Empty;
        s = s + s.CRLF();
        s = s + s.H4() + " " + title + " " + s.H4() + s.CRLF();
        s = s + "    Id: " + this.Id.ToString() + s.CRLF();
        s = s + "  Date: " + this.Date.ToString() + s.CRLF();
        s = s + "  Name: " + this.Name + s.CRLF();
        s = s + " Count: " + this.Count.ToString() + s.CRLF();
        s = s + s.CRLF();
        return s;
    }
    public int Ping(int x, int y)
    {
        return x + y;
    }
}