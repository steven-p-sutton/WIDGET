
public class WidgetNotFoundException : BaseException
{
    public WidgetNotFoundException()
    {
        this.Name = "WidgetNotFoundException";
    }
    public WidgetNotFoundException(string message)
        : base(message)
    {
    }
    public WidgetNotFoundException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
