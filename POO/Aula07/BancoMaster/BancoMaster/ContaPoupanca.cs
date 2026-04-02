using System;
using System.Collections.Generic;
using System.Text;

namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
		//Campo 
		private double juros;

        //Propriedade
        public double TaxaDeJuros
		{
			get { return juros; }
			set { juros = value; }
		}

        //Construtores
        public ContaPoupanca(string titularConta, int numeroConta, double taxaDeJuros) : base(titularConta, numeroConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public ContaPoupanca(double saldoConta, string titularConta, int numeroConta, double taxaDeJuros) : base(saldoConta, titularConta, numeroConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        //Métodos 

        public void AtualizacaoDoSaldo()
        { 
           SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
        }

        public override void Saque(double quantia)
        {
            SaldoConta -= quantia - 5;
        }
	}
}
