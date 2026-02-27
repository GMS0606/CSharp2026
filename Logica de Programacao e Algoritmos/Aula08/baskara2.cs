using System.Xml;
using static System.Console;
//---- funções-------
static double delta(double a, double b, double c)
{
    return (b*b) - (4 * a * c);
}
static void saida(double x1, double x2)
{
     WriteLine($"x1 = {x1}\x2 = {x2}");
}
static void reizes(double a, double b, double delta)
{
    double x1 = (-b - Math.Sqrt(delta)) /(2 * a);
    double x2 = (-b - Math.Sqrt(delta)) /(2 * a);
    saida(x1, x2);
}
//Problema Baskara
double a, b, c, delta1;
const string TEXTO = "Digite o valor de ";
// entrada de dados 
Write(TEXTO + "a:");
a = double.Parse(ReadLine());
Write(TEXTO + "b:");
b = double.Parse(ReadLine());
Write(TEXTO + "c:");
c = double.Parse(ReadLine());
//processamento
delta1 = delta (a, b, c);
//Estrutura
if (delta1 < 0)
{
    WriteLine("Raizes Impossiveis :(");
}
else if (delta1 == 0)
{
   reizes(a, b, delta1);
   
}
else
{
   reizes(a, b, delta1);
  
}
