using System;
using Moq;

public class MWidget : IMock
{

    public Mock<IWidget> _mMock;

    public MWidget()
    {
        _mMock = new Mock<IWidget>();
    }
    public Mock<IWidget> Mock
    {
        get => _mMock;
    }
    public override bool Returns
    {
        set
        {
            _mMock.Setup(x => x.Display(It.IsAny<string>()))
            .Returns((string x) => string.Empty);

            _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
            .Returns((int x, int y) => 0);

            if (value)
            {
                _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => 42);

                _mMock.Setup(x => x.Display(It.IsAny<string>()))
                .Returns((string x) => "Display called OK");
            }
        }
    }
    public override bool ReturnsAsync
    {
        set
        {
            _mMock.Setup(x => x.Display(It.IsAny<string>()));
            _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));

            if (value)
            {
                if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
                if (this.Run == RunType.FAIL_Display)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                }
                if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                }
            }
        }
    }
    public override bool Verifyable
    {
        set
        {
            _mMock.Setup(x => x.Display(It.IsAny<string>()));
            _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));

            if (value)
            {
                if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Verifiable();
                }
                if (this.Run == RunType.FAIL_Display)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Verifiable();
                }
                if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Verifiable();

                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Verifiable();
                }
            }
        }
    }
    public override bool Throws
    {
        set
        {
            _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
            _mMock.Setup(x => x.Display(It.IsAny<string>()));

            if (value)
            {
                if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                }
                if (this.Run == RunType.FAIL_Display)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);
                }
                if (this.Run == RunType.EXCEPTION)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);
                }
            }
        }
    }
    public override bool Verify
    {
        set
        {
            _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Never());
            _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Never());

            if (value)
            {
                if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
                }
                if (this.Run == RunType.FAIL_Display)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once());
                }
            }
        }
    }
    public override bool Arrange
    {
        set
        {
            if (value)
            {
                this.Verifyable = value;
                this.Returns = value;
                this.Throws = value;
            }
        }
    }
    public override bool Test
    {
        set
        {
            if (value)
            {
                if (this.Run == RunType.FAIL_Ping)
                {
                    Console.WriteLine(this.Mock.Object.Ping(2, 3));
                }
                if (this.Run == RunType.FAIL_Display)
                {
                    Console.WriteLine(this.Mock.Object.Display("Unit Test"));
                }
                if (this.Run == RunType.SUCCESS)
                {
                    Console.WriteLine(this.Mock.Object.Ping(2, 3));
                    Console.WriteLine(this.Mock.Object.Display("Unit Test"));
                }
            }
        }
    }
    public override bool Assert
    {
        set
        {
            if (value)
            {
                this.Verify = true;
            }
        }
    }
}
