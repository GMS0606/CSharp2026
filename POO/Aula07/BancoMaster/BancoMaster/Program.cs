
using static System.Console;
using BancoMaster;

WriteLine("Escolha qual conta deseja abrir:\n" +
    "\t1 - Conta comum\n" +
    "\t2 - Conta poupança\n" +
    "\t3 - Conta empresa");

int opcao = int.Parse(ReadLine());

WriteLine();

switch (opcao)
{
    case 1:
        Conta conta;
        Write("Digite o titular da conta: ");
        string titular = ReadLine();
        Write("Digite o número da conta: ");
        int numero = int.Parse(ReadLine());
        Write("Deseja fazer um deposito inicial (s/n): ");
        char escolhar = char.Parse(ReadLine());
        if (escolhar == 's')
        {
            Write("Digite o déposito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(deposito, titular, numero);
        }
        break;
} 