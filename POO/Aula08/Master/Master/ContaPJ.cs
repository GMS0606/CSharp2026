using System;
using System.Collections.Generic;
using System.Text;

namespace Master
{
    internal class ContaPJ : Conta
    {
		//Campo
		private double limite;

        //Propriedade
        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}
        public ContaPJ(int numeroconta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroconta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }

        //Método 

        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }
	}
}
