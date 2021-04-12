using System;
using Xunit;
using Conductus.MOCK.Model.Core;
using Conductus.WIDGET.Model.Core;

namespace Conductus.WIDGET.Test
{
    public class UnitTest
    {
        [Fact]
        public void Test1_MWidget()
        {
            var widget = new MWidget
            {
                Run = IRunType.SUCCESS,
                Arrange = true,
                Test = true,
                Assert = true
            };
        }
        [Fact]
        public void Test2_MWidget()
        {
            var widget = new MWidget
            {
                Run = IRunType.EXCEPTION,
                ExceptionExpected = new Exception("Widget Error"),
                Throws = true,
                Arrange = true
            };

            widget.ExceptionRaised = Assert.Throws<Exception>(() => widget.Test = true);
            Assert.Equal(widget.ExceptionExpected.Message, widget.ExceptionRaised.Message);
            widget.Assert = true;
        }
        [Fact]
        public void Test3_HWidget_Try()
        {
            var widget = new HWidget();
            widget.Try = true;
        }
        [Fact]
        public void Test4_HWidget_Ping()
        {
            var testWidget = new HWidget();
            Assert.Equal(3, testWidget.Ping());
        }
        [Fact]
        public void Test4_HWidget_Display()
        {
            var testWidget = new HWidget();
            Assert.Contains("TWidget", testWidget.Display());
        }
        [Fact]
        public void Test5_Widget_Ping()
        {
            var widget = new Widget();
            Assert.Equal(3, widget.Ping(1,2));
        }
        [Fact]
        public void Test6_Widget_Display()
        {
            var widget = new Widget();
            Assert.Contains("Widget", widget.Display("Widget"));
        }
    }
}

