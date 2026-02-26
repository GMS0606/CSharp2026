using static System.Console;
double nota1, nota2, resultado;

// ------entrada de dados------

Write ("Digite a primeira nota: ");
nota1 = double.Parse(ReadLine());
Write ("Digite a segunda nota: ");
nota2 = double.Parse(ReadLine());

//------Processamento de dados------

resultado = nota1 + nota2;

if (resultado < 60)
{
    WriteLine($" Nota final = {resultado}");
    WriteLine("REPROVADO :(");
}
else
{
    WriteLine($"Nota final = {resultado}");
    WriteLine("APROVADO :)");
}