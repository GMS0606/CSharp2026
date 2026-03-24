namespace Circunferencia03
{
    internal static class Calculadora
    {
        public static double PI = 3.14;

        public static double Circuferencia(double raio)
        {
            return 2 * PI * raio;
        }

        public static double Volume(double raio)
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);
        }

    }
}
