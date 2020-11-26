namespace Conductus.Widget.Exception
{
    public class WidgetAlreadyExistsException : BaseException
    {
        public WidgetAlreadyExistsException()
        {
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
            return ExceptionUtility.Display(this, "WidgetAlreadyExistsException");
        }
    }
}
