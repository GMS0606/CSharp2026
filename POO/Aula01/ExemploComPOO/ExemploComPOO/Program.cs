using ExemploComPOO;
using static System.Console;

Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("Digite as medidad do triângulo X: ");

WriteLine();

Console.WriteLine("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());
Console.WriteLine("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());
Console.WriteLine("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());

WriteLine();

Console.WriteLine("Digite as medidad do triângulo Y: ");

WriteLine();

Console.WriteLine("Digite a medida A: ");
y.ladoA = double.Parse(ReadLine());
Console.WriteLine("Digite a medida B: ");
y.ladoB = double.Parse(ReadLine());
Console.WriteLine("Digite a medida C: ");
y.ladoC = double.Parse(ReadLine());

//Saida de dados 

WriteLine();

WriteLine($"A área do trianguloe x é de: {x.Area() :F2}");
WriteLine($"A área do trianguloe y é de: {y.Area() :F2}");

ReadKey();