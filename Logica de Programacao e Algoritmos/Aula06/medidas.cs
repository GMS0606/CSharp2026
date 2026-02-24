
using static System.Console;
try {
// Declaração de variaveis 

double a, b, c, areaQuadrado, areTriangulo, areaTrapezio;

//Entrada de dados 

Write ("Digite a medida A: ");
a = double.Parse(ReadLine());
Write ("Digite a medida B: ");
b = double.Parse(ReadLine());
Write ("Digite a medida C: ");
c = double.Parse(ReadLine());

//Processamento de dados 

areaQuadrado = a * a; 
areTriangulo = (a * b)/2;
areaTrapezio = ((a + b) * c)/2;

//Saida de dados 

WriteLine($"A area do quadrado é: {areaQuadrado:F4} m² ");
WriteLine($"A area do Triangulo é: {areTriangulo:F4} m² ");
WriteLine($"A area do Trapezio é: {areaTrapezio:F4} m² ");

}

catch (Exception)

{
    WriteLine("Valores invalidos inseridos, programa encerrado!");

}
