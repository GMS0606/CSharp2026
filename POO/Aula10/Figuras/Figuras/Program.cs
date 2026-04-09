using Figuras.Classes.Enumeracoes;
using Figuras.Classes.Entidades;
using static System.Console;

List < Forma > fromas = new();

Write("Entre com a quantidade de formas");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geometrico n°{i + 1}: ");
    Write($"Retângulo ou Círculo (R/C): ");
    char escolhar = char.Parse(ReadLine().ToLower());
    if ( escolhar == 'r')
    {
        WriteLine("Qual é a cor do objeto? " +
            "\n\t1 - Vermelho" +
            "\n\t2 - Azul" +
            "\n\t3 - Amarelo" +
            "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
    }

}

