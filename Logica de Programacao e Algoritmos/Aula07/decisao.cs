//entrada de dados
double resultado = 1;
System.Console.WriteLine("Digite o numerador para realizr a divisão: ");
double entrada = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o denominador para realizar a divizão: ");
double entrada1 = double.Parse(Console.ReadLine());
//Processamento
if ((entrada > 0) & (entrada1 > 0))
{
  resultado = 2 / entrada;    
}
else if (entrada = 0)
{
    resultado = 2 - entrada;
}

else
{
    resultado = 2 + entrada;
}
//Saida de dados 
System.Console.WriteLine($"O resultado é {resultado}");

