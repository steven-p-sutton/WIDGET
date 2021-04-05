using System;
using Newtonsoft.Json;

public class Widget : IWidget
{
    // Default (optional) initialise to known good values
    public Widget()
    {
        Id = 0;
        Date = DateTimeOffset.MinValue;
        Name = string.Empty;
        Count = 0;
        Secret = string.Empty;
    }
    // Createclass constructors with multiple parameters
    public Widget(DateTimeOffset date)
    {
        Date = date;
    }
    public Widget(DateTimeOffset date, string secret)
    {
        Date = date;
        Secret = secret;
    }
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("date")]
    public DateTimeOffset Date { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("count")]
    public int Count { get; set; }
    [JsonProperty("secret")]
    public string Secret { get; set; } // not included in DTO version of class.
    public virtual string Display(string title)
    {
        string s = string.Empty;
        s = s + s.CRLF();
        s = s + s.H4() + " " + title + " " + s.H4() + s.CRLF();
        s = s + "    Id: " + this.Id.ToString() + s.CRLF();
        s = s + "  Date: " + this.Date.ToString() + s.CRLF();
        s = s + "  Name: " + this.Name + s.CRLF();
        s = s + " Count: " + this.Count.ToString() + s.CRLF();
        s = s + "Secret: " + this.Secret.ToString() + s.CRLF();
        s = s + s.CRLF();
        return s;
    }
    public virtual int Ping (int x, int y)
    {
        return x + y;
    }
}