using System;
using System.Collections.Generic;
using System.Text;

namespace Master
{
    internal class Poupanca : Conta
    {
		//campo
		private double rendimento;



        public double RendimentoConta
		{
			get { return rendimento; }
			set { rendimento = value; }
		}

		//Contrutor 
        public Poupanca(int numeroconta, double saldoConta, Pessoa dadosCliente, double rendimento) : base(numeroconta, saldoConta, dadosCliente)
        {
            RendimentoConta = rendimento;
        }

		//Método 

		public void consulta()
		{
			Console.WriteLine($"Dados do cliente - {Tipo.ContaPoupanca}\n" +
				$"\t Nome: {DadosCliente.nome}\n" +
				$"\t Numero: {Numeroconta}\n" +
				$"\t Saldo: {SaldoConta}\n" +
				$"\t Rendimento: {rendimento}%");
		}
	}
}
