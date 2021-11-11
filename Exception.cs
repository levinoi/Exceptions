using System;
namespace My_hometask_2
{
    public class MyhometaskException : System.Exception
    {
        public MyhometaskException(string message) : base(message) { }
    }

    class NonElectroDeviceException : MyhometaskException
    {
        public NonElectroDeviceException(string message) : base(message) { }
    }

    class NullPowerException : MyhometaskException
    {
        public NullPowerException(string message) : base(message) { }
    }

    class OutOfRangeException : MyhometaskException
    {
        public OutOfRangeException(string message) : base(message) { }
    }
    class OutOfCategoryException : MyhometaskException
    {
        public OutOfCategoryException(string message) : base(message) { }
    }
}



