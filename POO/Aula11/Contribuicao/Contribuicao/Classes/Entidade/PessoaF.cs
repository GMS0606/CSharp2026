namespace Contribuicao.Classes.Entidade
{
    internal class PessoaF : Contribuintes
    {
        private double saude;

        public double GastosSaude
        {
            get { return saude; }
            set { saude = value; }
        }


        public PessoaF(string nome, double renda, double gastos) : base(nome, renda)
        {
            GastosSaude = gastos;
        }

        public override double imposto()
        {
            return RendaAnual + (GastosSaude / 2);
        }

    }
}
