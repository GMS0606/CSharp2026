using System;
using System.Collections.Generic;
using System.Text;

namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        private double TaxadeJuros;
        public double taxa
        {
            get { return taxa; }
            set { taxa = value; }
        }

        //Contrtor
        public ContaPoupanca(string titularConta, int numeroConta, double taxadeJuro) : base(titularConta, numeroConta)
        {
            TaxadeJuros = taxadeJuro;
        }

        public ContaPoupanca(double saldoConta, string titularConta, int numeroConta, double taxadeJuro) : base(saldoConta, titularConta, numeroConta)
        {
            TaxadeJuros = taxadeJuro;
        }

       public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }




    }
}
