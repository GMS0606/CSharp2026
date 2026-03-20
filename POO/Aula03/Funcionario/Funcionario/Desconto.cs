

using Microsoft.VisualBasic;
using static System.Console;


namespace Funcionario
{
    internal class Desconto
    {
        //Campos da classe
        public string nome;
        public double salariobruto;
        public double imposto;



        //Contrutor 
        public Desconto(string nome, double salariobruto, double imposto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
            this.imposto = imposto;

        }

        //Métodos 
        public double salarioliquido()
        {
            return salariobruto - imposto;

        }

        public void aumentarsalario(double porcentagem)
        {
            salariobruto += salariobruto * porcentagem / 100.0;
        }
        public void dadofun()
        {
            Write($"Nome : {nome}" +
               $"\nSalário liquido: {salarioliquido()}");
        }

        public void dadofun1()
        {
            Write($"Nome : {nome}" +
               $"\nSalário liquido: {salarioliquido()}");
        }
    }
}
