/* elabore um aplicativo de console para ler dados de dois retangulos, altura e largura 
* em seguida mostr na saida de dados a area, perimetro e diagonal dos dois retangulos */

using RetanguloComPOO;
using static System.Console;

Retangulo01 x = new Retangulo01 ();
Retangulo01 y = new Retangulo01();


Console.WriteLine("Digite as medidad do retangulo X: ");
WriteLine();
Console.WriteLine("Digite a altura: ");
x.altura = double.Parse(ReadLine());
Console.WriteLine("Digite a largura: ");
x.largura = double.Parse(ReadLine());

WriteLine();

x.process();

WriteLine();

Console.WriteLine("Digite as medidad do retangulo Y: ");
WriteLine();
Console.WriteLine("Digite a altura: ");
y.altura = double.Parse(ReadLine());
Console.WriteLine("Digite a largura: ");
y.largura = double.Parse(ReadLine());

WriteLine();

y.process();

ReadKey();