namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Funcionario
    {
		//Campos
		private string nome;
		private int jornada;
		private double valor;

        //Propriedades
        protected string NomeColaboardor
		{
			get { return nome; }
			set { nome = value; }
		}
        protected int JornadaTrabalho
		{
			get { return jornada; }
			set { jornada = value; }
		}
        protected double ValorHora
		{
			get { return valor; }
			set { valor = value; }
		}

		//Construtores 
        public Funcionario(string nomeColaboardor, int jornadaTrabalho, double valorHora)
        {
            NomeColaboardor = nomeColaboardor;
            JornadaTrabalho = jornadaTrabalho;
            ValorHora = valorHora;
        }

		//Métodos
		
		public virtual double Pagamento()
		{
			return ValorHora * JornadaTrabalho;
		}

		public override string ToString()
		{
			return $"{NomeColaboardor} - {Pagamento():C}";
		}
	}
}
