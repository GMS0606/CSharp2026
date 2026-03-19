
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace terreno
{
    internal class Terreno
    {
        //Campos
        public double largura, comprimento, valor;

        //Contrutor 
        public Terreno(double largura, double comprimento, double valor)
        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }


        //Metodos

        public double Area()
        {
            return largura * comprimento;
        }

        public double preco()
        {
            return Area() * valor;
        }
        public void saida()
        {
            WriteLine();
            Console.WriteLine($"A area do terreno é de {Area()} m²");
            Console.WriteLine($"E o preço do terreno é de R${preco()}");
        }







    }
}
