using static System.Console;
using BancoMaster;

WriteLine("Escolha qual conta deseja abrir:\n" +
    "\t1 - Conta comum\n" +
    "\t2 - Conta poupança\n" +
    "\t3 - Conta empresa");

int opcao = int.Parse(ReadLine());

WriteLine();

Conta conta = null;

switch (opcao)
{
    case 1:
        Write("Digite o titular da conta: ");
        string titular1 = ReadLine();

        Write("Digite o número da conta: ");
        int numero1 = int.Parse(ReadLine());

        Write("Deseja fazer um deposito inicial (s/n): ");
        char escolha1 = char.Parse(ReadLine());

        if (escolha1 == 's')
        {
            Write("Digite o depósito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(deposito, titular1, numero1);
        }
        else
        {
            conta = new Conta(titular1, numero1);
        }
        break;

    case 2:
        Write("Digite o titular da conta: ");
        string titular2 = ReadLine();

        Write("Digite o número da conta: ");
        int numero2 = int.Parse(ReadLine());

        Write("Digite a taxa de juros: ");
        double juros = double.Parse(ReadLine());

        conta = new ContaPoupanca(titular2, numero2, juros);
        break;

    case 3:
        Write("Digite o titular da conta: ");
        string titular3 = ReadLine();

        Write("Digite o número da conta: ");
        int numero3 = int.Parse(ReadLine());

        Write("Digite o limite de empréstimo: ");
        double limite = double.Parse(ReadLine());

        conta = new ContaEmpresa(titular3, numero3, limite);
        break;

    default:
        WriteLine("Opção inválida!");
        return;
}

// Menu de operação (parte pesquisada :) )
int opcaoOperacao;

do
{
    WriteLine("\nEscolha uma operação:");
    WriteLine("1 - Depositar");
    WriteLine("2 - Sacar");
    WriteLine("3 - Ver saldo");
    WriteLine("4 - Sair");

    opcaoOperacao = int.Parse(ReadLine());

    switch (opcaoOperacao)
    {
        case 1:
            Write("Valor para depósito: ");
            double dep = double.Parse(ReadLine());
            conta.Deposito(dep);
            break;

        case 2:
            Write("Valor para saque: ");
            double saque = double.Parse(ReadLine());
            conta.Saque(saque);
            break;

        case 3:
            WriteLine($"Saldo atual: {conta.SaldoConta}");
            break;
    }

} while (opcaoOperacao != 4);

WriteLine("Programa encerrado.");