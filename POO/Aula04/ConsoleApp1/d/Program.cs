using Circunferencia02;
using static System.Console;
using static System.ConsoleColor;
Title = "Calculadora02";

//Entrada de dados 

Write("Digite o raio da circuferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();

//Crio o obketo do tipo Calculadora 
Calculadora c1 = new Calculadora(raio);

//Saida de dados 
WriteLine($"Circuferencia: {c1.Circuferencia():F2}");
WriteLine($"Volume{c1.Volume():F2}");
WriteLine($"PI: {c1.raio}");
