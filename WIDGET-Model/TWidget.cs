using System;
using Newtonsoft.Json;

public class TWidget
{
    Widget Widget {get; set;}
    public TWidget()
    {
        this.Widget = new Widget
        {
            Id = 0,
            Date = DateTimeOffset.MinValue,
            Name = string.Empty,
            Count = 0,
            Secret = string.Empty
        };
    }
    public TWidget(Widget widget)
    {
        this.Widget = widget;
    }
    public bool Test
    {
        set
        {
            if (value)
            {
                this.Widget.Ping(1, 2);
                this.Widget.Display("Test");
            }
        }
    }
    public int Ping()
    {
        return this.Widget.Ping(1, 2);
    }
    public string Display()
    {
        return this.Widget.Display("TWidget");
    }
}