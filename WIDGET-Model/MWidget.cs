using System;
using Moq;
//using MOCK.Framework;

public class MWidget : IMock
    {
        public Mock<Widget> _mMock;
        public MWidget()
        {
            _mMock = new Mock<Widget>();
        }
        public Mock<Widget> Mock
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
        public override RunType Throws
        {
            set
            {
                if (value == RunType.EXCEPTION)
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
        public override int Verify
        {
            set
            {
                if (value == 0)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once()); // TBC
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Never());
                }
                else if (value == 1)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
                }
                else
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Exactly(value));
                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(value));
                }
            }
        }
        public override RunType Arrange
        {
            set
            {
                if (value == RunType.SUCCESS)
                {
                    this.Verifyable = true;
                    this.Returns = true;
                }
                else
                    this.Throws = value;
            }
        }
        public override RunType Test
        {
            set
            {
                if (value == RunType.SUCCESS)
                {
                    Console.WriteLine(this.Mock.Object.Display("Unit Test"));
                    Console.WriteLine(this.Mock.Object.Ping(2, 3));
                }
                else
                {
                    Console.WriteLine(this.Mock.Object.Display("Unit Test"));
                    Console.WriteLine(this.Mock.Object.Ping(2, 3));
                }
            }
        }
        public override RunType Assert
        {
            set
            {
                if (value == RunType.SUCCESS)
                    this.Verify = 1;
                else
                    this.Verify = 0; // TBC
            }
        }
    }
