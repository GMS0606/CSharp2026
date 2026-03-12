using static System.Console;
//declaração de um dicionario 
Dictionary<int, double > produtos = new Dictionary<int, double>()
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}

};

bool valido = false;

while (!valido)
{

try
{
    ForegroundColor = ConsoleColor.Yellow; 
    Write("Digite o código do produto: ");
    ResetColor();
    int codigo = int.Parse(ReadLine());

    if (produtos.ContainsKey(codigo))
    {
        ForegroundColor = ConsoleColor.Blue; 
        Write("Digite a quantidade comprada: ");
        ResetColor();
        int quantidade = int.Parse(ReadLine());
        double valor = produtos [codigo] * quantidade;
        ForegroundColor = ConsoleColor.Magenta;
        Write("O valor a ser pago é: ");
        ResetColor();
        WriteLine($"${valor:F2}");

        valido = true;
    }
    else
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("caractere invalido tente novamente ^_^");
        ResetColor();
        
    }

}
catch (Exception ex)
 {
    ForegroundColor = ConsoleColor.Red;
    WriteLine("caractere invalido "  + ex.Message);
    ResetColor();
 }
}