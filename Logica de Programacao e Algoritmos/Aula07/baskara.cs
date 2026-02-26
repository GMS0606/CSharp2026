using static System.Console;
//Problema Baskara
double a, b, c, delta, x1, x2;
//Entrada de dados 
Write("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
Write("Digite o valor de c: ");
c = double.Parse(ReadLine());
//processamento
delta = (b*b) - (4 * a * c);
//Estrutura de controle 
if (delta < 0)
{
    WriteLine("Raizes Impossiveis");
}
else if (delta == 0)
{
    x1 = -b/ (2*a);
    x2 = x1;
    WriteLine($"x1 = {x1}\x2 = {x2}");
}
else
{
    x1 = (-b - Math.Sqrt(delta)) /(2 * a);
    x2 = (-b - Math.Sqrt(delta)) /(2 * a);
    WriteLine($"x1 = {x1}\nx2 = {x2}");
}
