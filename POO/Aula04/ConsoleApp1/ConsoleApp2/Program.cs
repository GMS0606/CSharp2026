using Circunferencia03;
using static System.Console;
using static System.ConsoleColor;
using static System.Circunferencia03.Calculadora;

Title = "Calculadora03";
Write("Digite o raio da cincuferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();

WriteLine($"Circuferencia: {Circunferncia(raioo):F2}");
WriteLine($"Volume: {Volume(raio):F2"};
WriteLine($"PI: {PI}");

