using Figuras.Classes.Enumeracoes;
using System.Security.Cryptography.X509Certificates;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma

    {
		private double largura;
		private double altura;



        protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}

		protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		//Contrutor

		public Retangulo(Cor corDaForma, double altura, double largura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }

		/// <summary>
		/// Calcula a área da forma usando as dimensõs atuais.
		/// </summary>
		/// <returns>O valor da área calcula com base na largura e altura do retângulo.</returns>

        public override double Area()
        {
            return Largura * Altura;
        }
	}
}
