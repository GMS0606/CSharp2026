namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        private double limite;

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(string titularConta, int numeroConta, double limiteConta)
            : base(titularConta, numeroConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(double saldoConta, string titularConta, int numeroConta, double limiteConta)
            : base(saldoConta, titularConta, numeroConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Métodos 

        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}