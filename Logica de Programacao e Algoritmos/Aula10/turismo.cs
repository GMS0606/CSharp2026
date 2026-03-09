using static System.Console;

string direcao;
int turistas, totalTuristas = 0;

while (true)
{
    ForegroundColor = ConsoleColor.Magenta;  /// Foi pesquisado 
    WriteLine("Aplicativo de controle de fluxo de carro");
    WriteLine("Parque nacional dos Lençóis Maranhenses");
    WriteLine();
    ResetColor();

    ForegroundColor = ConsoleColor.Cyan;  /// Foi pesquisado 
    Write("Digite o fluxo de carro (entrada/saida) ou sair para encerrar a aplicação: ");
    ResetColor();
    direcao = ReadLine()!;

    if (direcao == "sair")
    {
        ForegroundColor = ConsoleColor.Yellow;  /// Foi pesquisado 
        WriteLine("Expediente encerrado ;)");
        ResetColor();
        break;
    }

   
    if (direcao != "entrada" && direcao != "saida")
    {
        ForegroundColor = ConsoleColor.Red;  /// Foi pesquisado 
        WriteLine("Palavra inválida, tente novamente.");
        ResetColor();
        continue;
    }

    ForegroundColor = ConsoleColor.Cyan; /// Foi pesquisado 
    Write("Digite a quantidade de turistas (0 a 4): ");
    ResetColor();
    turistas = int.Parse(ReadLine()!);

    if (turistas <= 0 || turistas > 4)
    {
        ForegroundColor = ConsoleColor.Red;  /// Foi pesquisado 
        WriteLine("Quantidade de turistas inválida. Tente novamente.");
        ResetColor();
        continue;
    }

    string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");  /// Foi pesquisado 

    if (direcao == "entrada")
    {
        totalTuristas += turistas;

        ForegroundColor = ConsoleColor.Green;  /// Foi pesquisado 

        WriteLine($"[{dataHora}] Entrada registrada: {turistas} turistas");
        ResetColor();
    }
    else if (direcao == "saida")
    {
        totalTuristas -= turistas;

        if (totalTuristas < 0)
        {
            totalTuristas = 0;
        }

        ForegroundColor = ConsoleColor.Yellow;  /// Foi pesquisado 
        WriteLine($"[{dataHora}] Saída registrada: {turistas} turistas");
        ResetColor();
    }

    ForegroundColor = ConsoleColor.Magenta;  /// Foi pesquisado 
    WriteLine($"Total de turistas no parque: {totalTuristas}");
    ResetColor();
}