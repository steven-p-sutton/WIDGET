using system;

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
    public WidgetDTO WidgetToDTO(WidgetObject widget) => new WidgetDTO(widget);
    public long Id { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public string Display(string title)
    {
        string s = Environment.NewLine;
        s = s + Heading.H4 + " " + title + " " + Heading.H4 + Environment.NewLine;
        s = s + "    Id: " + this.Id.ToString() + Environment.NewLine;
        s = s + "  Date: " + this.Date.ToString() + Environment.NewLine;
        s = s + "  Name: " + this.Name + Environment.NewLine;
        s = s + " Count: " + this.Count.ToString() + Environment.NewLine;
        s = s + Environment.NewLine;
        return s;
    }
}
