using System;
using Conductus.CODERUN.Model.Core;
using Conductus.MOCK.Model.Core;
//using Conductus.WIDGET.Model.Core;

namespace Conductus.WIDGET.CODERUN
{
    public class WidgetCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Widget MOQ Code Run"; }
        }

        public void Run()
        {
            try
            {
                var widget = new MWidget
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                var widget2 = new MWidget
                {
                    Run = IMock.RunType.EXCEPTION,
                    ExceptionExpected = new Exception("Widget Error"),
                    Throws = IMock.RunType.EXCEPTION,
                    Arrange = IMock.RunType.EXCEPTION,
                    Test = IMock.RunType.EXCEPTION,
                    Assert = IMock.RunType.EXCEPTION
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
