using System;
//using Conductus.Widget.Object; // .NET WIDGET-Object.dll
// WIDGET-Model doesn't require 'using' as code is imported in
using Conductus.Widget.Exception;

namespace Conductus.Widget.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WIDGET-Try World!");

            try
            {
                WidgetObject w = new WidgetObject();
                w.Display("w");
                WidgetDTO wd = new WidgetDTO();
                wd.Display("wd");

                throw new WidgetNotFoundException(
                    String.Format("Widget {0} Not Found", wd.Id));
            }
            catch (WidgetNotFoundException e)
            {
                ExceptionUtility.Display(e, "wd");
            }
        }
    }
}
