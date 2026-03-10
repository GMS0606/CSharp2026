using static System.Console;
using static System.Linq.Enumerable;
//declaração
int n;
//entrada
Write ("Quantos numero você vai digitar entre 1 e 10?:  ");
n = int.Parse(ReadLine());
if (n < 0)
{
   ForegroundColor = ConsoleColor.Blue;
   WriteLine ("Valor invalido, digite somente números possitivos! ;) ");
   ResetColor();
}
else if (n > 10)
{
   ForegroundColor = ConsoleColor.Red;
   WriteLine ("Máximo de valores para digitar igual a 10, tente novamente! :) ");
   ResetColor();
}
else
{
    //declarção do vetor 
    int [] numeros = new int [n];
    for (int i = 0 ; i < numeros.Length; i++)
    {
        WriteLine();
        Write("Digite um número: ");
        numeros[i] = int.Parse(ReadLine());
    }
    WriteLine();
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("NÚMEROS NEGATIVOS: ");
    ResetColor();
    foreach (int item in Range(0, numeros.Length))
    {
        if (numeros[item] <0)
        {
            WriteLine(numeros[item]);
        }
    }
}