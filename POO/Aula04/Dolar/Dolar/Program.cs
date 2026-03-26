using Dolar;
using System;
using static System.Console;

Write("qual é a cotação do dolar? : ");
Console.ForegroundColor = ConsoleColor.Magenta;
ConversorDeMoeda.cotacao = double.Parse(ReadLine());
ResetColor();
Write("Quantos dolares voce vai comprar?: ");
Console.ForegroundColor = ConsoleColor.Magenta;
ConversorDeMoeda.qtd = double.Parse(ReadLine());
ResetColor();
WriteLine();
Write($"Valor a ser pago em reais é de: R${ConversorDeMoeda.CalcularValor():F2}");
ReadKey();
