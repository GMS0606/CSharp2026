using static System.Console;
int numero, valor;
try
{
//entrada
    Write("Quantos numeros você vai digitar? ");
    numero = int.Parse(ReadLine());
//processamento
for (int i = 0; i <numero; i++)
    {
        Write("digite um número: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            Write ("Negativo :( ");
        }

    else if (valor > 0)
        {
            Write ("Possitivo :) ");
        }
        else
        {
             Write ("nulo :| ");
        }
        if ((valor % 2) == 0)
        {
             Write ("( par ) ");
        }
        else if ((valor % 2) != 0)
        {
            Write (" ( impar ) ");
        }

    }

}
catch (Exception ex)
{
    
    WriteLine($"Valor invalido, erro =, {ex.Message}");
}