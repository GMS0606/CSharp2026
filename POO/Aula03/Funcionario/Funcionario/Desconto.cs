using System;
using static System.Console;

namespace Funcionario
{
    internal class Desconto
    {
        // Campos da classe
        public string nome;
        public double salariobruto;
        public double imposto;

        // Construtor 
        public Desconto(string nome, double salariobruto, double imposto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
            this.imposto = imposto;
        }

        // Métodos 
        public double salarioliquido()
        {
            return salariobruto - imposto;
        }

        public void aumentarsalario(double porcentagem)
        {
            double liquidoAtual = salarioliquido();
            double aumento = liquidoAtual * porcentagem / 100.0;
            double novoLiquido = liquidoAtual + aumento;

            salariobruto = novoLiquido + imposto;
        }

        public void dadofun()
        {
            WriteLine($"Nome: {nome}");
            WriteLine($"Salário líquido: {salarioliquido():F2}");
        }

        
    }
}