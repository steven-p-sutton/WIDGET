using System;
//using Conductus.Widget.Object; // .NET WIDGET-Object.dll
// WIDGET-Model doesn't require 'using' as code is imported in
using Conductus.EXCEPTION.Model.Net;

namespace Conductus.WIDGET.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget w = new Widget();

            try
            {

                w.Id = 1;
                w.Display("w");

                WidgetDTO wd = new WidgetDTO();
                wd.Id = 2;
                wd.Display("wd");

                throw new WidgetNotImplentedException(
                    String.Format("Error in Widget {0}", wd.Id));
            }
            catch (WidgetNotImplentedException e)
            {
                Console.WriteLine(e.Display());
                Console.WriteLine(w.Display("Widget In Error"));
            }
        }
    }
}
