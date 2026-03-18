using static System.Console;

//Entrada de dados 
WriteLine("Digite as medidas do triângulo X:");

Write("Digite o valor de A: ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de B: ");
double bx = double.Parse(ReadLine());
Write("Digite o valor de C: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triângulo Y:");

Write("Digite o valor de A: ");
double ay = double.Parse(ReadLine());
Write("Digite o valor de B: ");
double by = double.Parse(ReadLine());
Write("Digite o valor de C: ");
double cy = double.Parse(ReadLine());



// Processamento de dados 

double px = (ax + bx + cx) / 2;
double py = (ax + bx + cx) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(px * (py - ay) * (py - by) * (py - cy));

WriteLine();

WriteLine($"Á área do trângulo x é de {areax:F2}");
WriteLine($"Á área do trângulo y é de {areay:F2}");

if (areax > areay)
{
    WriteLine();
    WriteLine("Maior área é do triângulo X :)");
}
else if (areay > areax )

{
    WriteLine();
    WriteLine("Maior área é do triângulo Y :)");
}
else
{
    WriteLine();
    WriteLine("A área dos triângulos são iguais ;)");
}
  ReadKey();