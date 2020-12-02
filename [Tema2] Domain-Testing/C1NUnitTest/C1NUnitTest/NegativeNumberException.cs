using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace C1NUnitTest
{   
    [Serializable]
    internal class NegativeNumberException : Exception
    {

        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message) : base(message)
        {
        }

        public NegativeNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
