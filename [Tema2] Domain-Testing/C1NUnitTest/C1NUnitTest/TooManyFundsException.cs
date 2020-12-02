using System;
using System.Runtime.Serialization;

namespace C1NUnitTest
{
    [Serializable]
    internal class NotEnoughFundsException : Exception
    {
        public NotEnoughFundsException()
        {
        }

        public NotEnoughFundsException(string message) : base(message)
        {
        }

        public NotEnoughFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}