﻿namespace Conductus.Widget.Exceptions
{
    // https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions

    public class WidgetAlreadyExistsException : System.Exception
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
    }
}
