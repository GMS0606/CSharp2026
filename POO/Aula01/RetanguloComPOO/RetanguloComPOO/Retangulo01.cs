

using System.Reflection.Metadata.Ecma335;
using static System.Console;


namespace RetanguloComPOO
{
    internal class Retangulo01
    {
        public double altura;
        public double largura;


        public void process()

        {

            double Area = altura * largura;
            double Perimetros = ((altura * 2) + (largura * 2));
            double diagonal = Math.Sqrt((altura * largura) + (altura * largura));
            Write($"A área é {Area}, o perímetro é {Perimetros} e a diagonale é {diagonal:F2}");
        }
    }
}