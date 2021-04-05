public class WidgetNotImplentedException : BaseException
{
    public WidgetNotImplentedException()
    {
        this.Name = "WidgetNotImplentedException";
    }
    public WidgetNotImplentedException(string message)
        : base(message)
    {
    }
    public WidgetNotImplentedException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
