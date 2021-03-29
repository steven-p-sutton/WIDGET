using System;
using Xunit;
using Conductus.MOCK.Framework.Core;
using Conductus.WIDGET.Model.Core;

namespace TEST_Employee
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            var widget = new MWidget
            {
                Run = IMock.RunType.SUCCESS,
                Arrange = IMock.RunType.SUCCESS,
                Test = IMock.RunType.SUCCESS,
                Assert = IMock.RunType.SUCCESS
            };
        }

        [Fact]
        public void Test2()
        {
            var widget = new MWidget
            {
                Run = IMock.RunType.EXCEPTION,
                ExceptionExpected = new Exception("Widget Error"),
                Throws = IMock.RunType.EXCEPTION,
                Arrange = IMock.RunType.EXCEPTION
            };

            widget.ExceptionRaised = Assert.Throws <Exception>(() => widget.Test = IMock.RunType.EXCEPTION);
            Assert.Equal(widget.ExceptionExpected.Message, widget.ExceptionRaised.Message);
            widget.Assert = IMock.RunType.EXCEPTION;
        }
    }
}

