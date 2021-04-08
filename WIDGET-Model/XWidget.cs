using System;
public class WidgetAlreadyExistsException : BaseException
{
    public WidgetAlreadyExistsException()
    {
        this.Name = "WidgetAlreadyExistsException";
    }
    public WidgetAlreadyExistsException(string message)
        : base(message)
    {
    }
    public WidgetAlreadyExistsException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
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
