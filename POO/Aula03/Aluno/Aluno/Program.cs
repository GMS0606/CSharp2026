using static System.Console;
using Aluno;

Write("Nome do Aluno: ");
Console.ForegroundColor = ConsoleColor.Yellow;
string nome = ReadLine();
ResetColor();

WriteLine("Digite as três notas do aluno: ");
double nota1 = double.Parse(ReadLine());
double nota2 = double.Parse(ReadLine());
double nota3 = double.Parse(ReadLine());

Nota aluno = new Nota(nome, nota1, nota2, nota3);

WriteLine($"\nNota final = {aluno.NotaFinal()}");

if (aluno.AprovadoOuReprovado())
{
    Console.ForegroundColor = ConsoleColor.Green;
    WriteLine("APROVADO");
    ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    WriteLine("REPROVADO");
    ResetColor();
    WriteLine($"Faltaram {aluno.Ponto()} pontos");
}

ReadKey();