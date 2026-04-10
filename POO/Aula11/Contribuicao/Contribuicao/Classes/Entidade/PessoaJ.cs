namespace Contribuicao.Classes.Entidade
{
    internal class PessoaJ : Contribuintes
    {
        private int funcionario;

        public int NumeroFuncionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }

        public PessoaJ(string nome, double renda, int funcionario) : base(nome, renda)
        {
            NumeroFuncionario = funcionario;
        }

        public override double imposto()
        {
            if (NumeroFuncionario > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
