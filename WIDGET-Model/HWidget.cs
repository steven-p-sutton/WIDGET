using System;
using Newtonsoft.Json;

public class HWidget
{
    Widget Widget {get; set;}
    public HWidget()
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
    public HWidget(Widget widget)
    {
        this.Widget = widget;
    }

    /// <summary>
    /// An overall confidence test to try out the class 
    /// </summary>
    public bool Try
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
    /// <summary>
    /// Each class method / property to hae a call to exercise it 
    /// </summary>
    public int Ping()
    {
        return this.Widget.Ping(1, 2);
    }
    public string Display()
    {
        return this.Widget.Display("HWidget");
    }
}