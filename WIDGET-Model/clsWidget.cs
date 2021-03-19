using System;

public class WidgetObject
{
    // Default (optional) initialise to known good values
    public WidgetObject()
    {
        Id = 0;
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
    public string Display(string title)
    {
        string s = Environment.NewLine;
        s = s + Heading.H4 + " " + title + " " + Heading.H4 + Environment.NewLine;
        s = s + "    Id: " + this.Id.ToString() + Environment.NewLine;
        s = s + "  Date: " + this.Date.ToString() + Environment.NewLine;
        s = s + "  Name: " + this.Name + Environment.NewLine;
        s = s + " Count: " + this.Count.ToString() + Environment.NewLine;
        s = s + "Secret: " + this.Secret.ToString() + Environment.NewLine;
        s = s + Environment.NewLine;
        return s;
    }
    public int Ping (int x, int y)
    {
        return x + y;
    }
}