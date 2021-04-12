using System;
using Conductus.CODERUN.Model.Core;
using Conductus.MOCK.Model.Core;
using Conductus.WIDGET.Model.Core;

namespace Conductus.WIDGET.CODERUN
{
    public class WidgetCodeRun : ACodeRunModule
    {
        public override string Title
        {
            get { return "Widget MOQ Code Run"; }
        }

        public override void Run()
        {
            try
            {
                var widget = new MWidget
                {
                    Run = RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var widget2 = new MWidget
                {
                    Run = RunType.FAIL_Ping,
                    ExceptionExpected = new Exception("Widget Error"),
                    Throws = true,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
