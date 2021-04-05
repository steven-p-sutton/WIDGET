using System;
using Conductus.CODERUN.Model.Core;
using Conductus.WIDGET.CODERUN;

namespace Conductus.CODERUN.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var wd = new WidgetCodeRun();
            CodeRun.Run(wd);
        }
    }
}
