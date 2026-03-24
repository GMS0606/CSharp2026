using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 01";

//Declaração
double raio;
const double PI = 3.14;

//Entrada 
Write("Entre com o valor do raio da circunferancia: ");
ForegroundColor = ConsoleColor.Red;
raio = double.Parse(ReadLine());
ResetColor();

//Saida de dados 
WriteLine($"Circuferencia: {CircuFerencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");


//Calculo da circuferncia 
double CircuFerencia(double r)
{
    return 2 * PI * r;
}
double Volume (double r)
{
    return (4 / 3) * PI * r;
}
