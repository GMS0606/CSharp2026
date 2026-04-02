using System;
using System.Collections.Generic;
using System.Text;

namespace BancoMaster 
{
    internal class ContaEmpresa : Conta
 {

		private double limite;

        //Propriedade
        public double LimiteEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}

        public ContaEmpresa(string titularConta, int numeroConta,double limite) : base(titularConta, numeroConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(double saldoConta, string titularConta, int numeroConta, double limite) : base(saldoConta, titularConta, numeroConta)
        {
            LimiteEmprestimo = limite;
        }

        public void Emprestimo (double quantidade)
        {
            LimiteEmprestimo -= quantidade;
            SaldoConta += quantidade;
        }


	}
}
