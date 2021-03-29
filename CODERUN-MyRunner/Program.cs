using System;
using Conductus.CODERUN.Library.Core;
using Conductus.CODERUN.WIDGET;

namespace CODERUN_MyRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var wd = new WidgetCodeRun();
            CodeRunFramework.Run(wd);
        }
    }
}
