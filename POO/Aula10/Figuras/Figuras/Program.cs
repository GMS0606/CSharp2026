using Figuras.Classes.Enumeracoes;
using Figuras.Classes.Entidades;
using static System.Console;

List < Forma > formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geometrico n°{i + 1}: ");
    Write($"Retângulo ou Círculo (R/C): ");
    char escolhar = char.Parse(ReadLine().ToLower());
    if (escolhar == 'r')
    {
        WriteLine("Qual é a cor do objeto? " +
            "\n\t1 - Vermelho" +
            "\n\t2 - Azul" +
            "\n\t3 - Amarelo" +
            "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
        WriteLine("Digite a largura do retângulo: ");
        double l = double.Parse(ReadLine());
        Write("Digite a altura do retâmgulo: ");
        double a = double.Parse(ReadLine());
        formas.Add(new Retangulo((Cor)cor, l, a));
    }
    else if (escolhar == 'c')
    {
        WriteLine("Qual é a cor do objeto? " +
           "\n\t1 - Vermelho" +
           "\n\t2 - Azul" +
           "\n\t3 - Amarelo" +
           "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
        Write("Digite o raio da circuferencia: ");
        double r = double.Parse(ReadLine());
        formas.Add(new Circulo((Cor)cor, r));

    }

}

foreach (var figurinhas in formas)
{
    Write(figurinhas.ToString());
}
