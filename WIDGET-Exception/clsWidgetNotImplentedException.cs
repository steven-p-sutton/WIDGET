namespace Conductus.Widget.Exception
{
    public class WidgetNotImplentedException : BaseException
    {
        public WidgetNotImplentedException()
        {
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
            return ExceptionUtility.Display(this, "WidgetNotImplentedException");
        }
    }
}
