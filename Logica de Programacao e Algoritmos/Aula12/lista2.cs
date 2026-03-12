using static System.Console;

int n;
List<double> numero = new List<double>();

Write("Quantos números você vai digitar? ");
n = int.Parse(ReadLine());

for (int i = 0; i < n ; i++)
{
    WriteLine();
    Write("Digite um número: ");
    numero.Add(double.Parse(ReadLine()));
}
WriteLine();
 Write ("Valore = ");

for (int i = 0; i < n ; i++)
{
   
    Write($" {numero [i]}");

}

Write ($"\nSoma= {numero.Sum()}");
Write($"\nMédia = {numero.Average()}");