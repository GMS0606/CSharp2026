using static System.Console;

//Declaração
int numero;
//Entrada de dadados
Write("Digite o numero da tabuada: ");
numero = int.Parse(ReadLine());
//Processamento
for (int i = 0; i < 10; i++)
{
    WriteLine($"{numero} x {i+1} = {numero * (i+1)}");
} 