using Contribuicao.Classes.Imposto;

namespace Contribuicao.Classes.Entidade
{
    abstract internal class Contribuintes : Iimposto
    {
        // Campos
        private string nome;
        private double renda;

        // Propriedades
        public string NomePessoa
        {
            get { return nome; }
            set { nome = value; }
        }

        public double RendaAnual
        {
            get { return renda; }
            set { renda = value; }
        }

        // Construtor
        public Contribuintes(string nome, double renda)
        {
            NomePessoa = nome;
            RendaAnual = renda;
        }

        // Método

        abstract public double imposto();

    }
}