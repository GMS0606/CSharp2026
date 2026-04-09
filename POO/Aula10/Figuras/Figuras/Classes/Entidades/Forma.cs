using Figuras.Classes.Contratos;
using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    abstract internal class Forma : IAre

    {
        /// <summary>
        /// Cores disponiveis Vermelho, Azul, Amarelo e Rosa
        /// </summary>
        
        //Campos

        private Cor cor;

        //Propriedade
        protected Cor CorDaForma

        {
            get { return cor; }
            set { cor = value; }
        }

        //Construtor
        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        //Métodos 

        abstract public double Area();

    }
}
