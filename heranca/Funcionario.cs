namespace heranca
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
          
         
    }
}