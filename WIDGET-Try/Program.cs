using System;
//using Conductus.Widget.Object; // .NET WIDGET-Object.dll
// WIDGET-Model doesn't require 'using' as code is imported in

namespace Conductus.Widget.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WIDGET-Try World!");

            WidgetObject w = new WidgetObject();
            WidgetDTO wd = new WidgetDTO();
        }
    }
}
