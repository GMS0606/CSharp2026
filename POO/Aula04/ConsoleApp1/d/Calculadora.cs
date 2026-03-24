using System;

namespace Circunferencia02
{
    internal class Calculadora
    {
        // Campo
        public const double PI = 3.14;
        public double raio;

        public Calculadora(double raio)
        {
            this.raio = raio;
        }

        // Métodos
        public double Circuferencia()
        {
            return 2 * PI * raio;
        }

        public double Volume()
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);
        }
    }
}