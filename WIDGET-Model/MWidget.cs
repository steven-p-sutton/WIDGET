using System;
using Moq;
//using MOCK.Framework;

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
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                     .Returns((string x) => "Display called OK");

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                     .Returns((int x, int y) => 42);
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                     .Returns((string x) => string.Empty);

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                     .Returns((int x, int y) => 0);
                }
            }
        }
        public override bool ReturnsAsync
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
            }
        }
        public override bool Verifyable
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Verifiable();

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Verifiable();
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
            }
        }
    public override bool Throws
    {
        set
        {
            if (value)
            {
                if (this.Run == RunType.EXCEPTION)
                {

                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));
                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
            }
        }
    }
    public override bool Verify
    {
        set
        {
            if (value)
            {
                if (this.Run == RunType.EXCEPTION)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once()); // TBC
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Never());
                }
                else if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
                }
                else
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.AtLeastOnce());
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());
                }
            }
            else
            {
                _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Never());
                _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Never());
            }
        }
    }
    public override bool Arrange
    {
        set
        {
            if (this.Run == RunType.SUCCESS)
            {
                this.Verifyable = true;
                this.Returns = true;
            }
            else
                this.Throws = value;
        }
    }
    public override bool Test
    {
        set
        {
            if (value)
            {
                Console.WriteLine(this.Mock.Object.Display("Unit Test"));
                Console.WriteLine(this.Mock.Object.Ping(2, 3));
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
