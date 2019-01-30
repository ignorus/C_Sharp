using System;
using System.Runtime.Serialization;

namespace excecao
{
    public class OperacaoFinanceiraExecption : Exception
    {
        public OperacaoFinanceiraExecption()
        {
        }

        public OperacaoFinanceiraExecption(string message) : base(message)
        {
        }

        public OperacaoFinanceiraExecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OperacaoFinanceiraExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}