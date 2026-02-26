using static System.Console;

double a, b, c, p, area, resultado;


Write("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
Write("Digite o valor de c: ");
c = double.Parse(ReadLine());

if (a < b + c & b < a + c & c < a + b)
{
    p = (a + b + c) / 2;
    resultado = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    WriteLine($"A area do triangulo é {resultado} m²");
}
else
{
    area = (( a + b) * c)/2;
    WriteLine($"a area do trapezio é {area} m²");
}