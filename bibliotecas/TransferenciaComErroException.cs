using System;
using System.Runtime.Serialization;

namespace excecao
{
    public class TransferenciaComErroException : Exception
    {
        public TransferenciaComErroException()
        {
        }

        public TransferenciaComErroException(string message) : base(message)
        {
        }

        public TransferenciaComErroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TransferenciaComErroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}