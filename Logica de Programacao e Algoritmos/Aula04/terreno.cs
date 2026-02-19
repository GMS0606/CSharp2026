//Crie um aplicativo de console no qual o usuário tenha que digitar três valores, a largura,
//o comprimento e o valor do m2 do terreno e em seguida calcule a area do terreno e o preço do terreno e mostre esses valores na saida de dados 

using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using static System.Console;
//Declaração de variaveis 
double largura, comprimento, valor, area, preco;
//Entrada de dodos
Write("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
WriteLine();
WriteLine("Digite o comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
WriteLine();
WriteLine("Digite o valor m² do terrno: ");
valor = double.Parse(ReadLine()); //Conversão de dados para double 
WriteLine();
area = largura * comprimento; //Calcula a area do terreno 
preco = area * valor; //Calcula o preço
WriteLine($"A area do terreno é: {area} m² e o valor do terreno é R$ {preco}"); // Saida de dados 