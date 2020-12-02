using System;
using System.Runtime.Serialization;

namespace C1NUnitTest
{
    [Serializable]
    internal class TooManyFundsException : Exception
    {
        public TooManyFundsException()
        {
        }

        public TooManyFundsException(string message) : base(message)
        {
        }

        public TooManyFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}