using static System.Console;

double baseRetangulo, altura, area, perimetro, diagonal; 

Write("Digite a base do retângulo: ");
baseRetangulo = double.Parse(ReadLine());
Write("Digite a altura do retângulo: ");
altura = double.Parse(ReadLine());
WriteLine();
area = altura * baseRetangulo;
perimetro = 2 * (baseRetangulo + altura);
diagonal = Math.Sqrt ((baseRetangulo * baseRetangulo) + (altura * altura));
WriteLine($"A area do Retângulo é: {area} m² ");
WriteLine($"O perimetro do Retângulo é: {perimetro} ");
WriteLine($"A diagonal do Retângulo é: {diagonal} ");