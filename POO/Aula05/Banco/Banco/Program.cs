using Banco;
using static System.Console;
using static System.Globalization.CultureInfo;


Title = "Abertura de conta";
ContaBancaria conta;

Console.ForegroundColor = ConsoleColor.Magenta;
WriteLine("Abertura de conta - Nika Ivestment");
ResetColor();
WriteLine();
Write("Entre com um número de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular: ");
string nome = ReadLine();
Write("Deseja fazer um depósito inicial (s/n): ");
char resposta = char.Parse(ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre com o valor de depósito inicial: R$");
    double deposito = double.Parse(ReadLine());

    conta = new ContaBancaria(numero, nome, deposito);



}
else
{
     conta = new ContaBancaria(numero, nome); 
}

WriteLine();
conta.dados();

WriteLine();
Write("Entre com um valor para depósito: ");
double quantidade = double.Parse(ReadLine());
conta.Deposito(quantidade);
conta.dados();

WriteLine();
Write("Entrada com um valor para saque: ");
quantidade = double.Parse(ReadLine());
conta.Saque(quantidade);
conta.dados();

ReadKey();