using System;

namespace bibliotecas
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
    }
}