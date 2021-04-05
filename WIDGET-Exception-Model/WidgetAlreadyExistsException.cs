//namespace Conductus.WIDGET.Exception
//{
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
//}
