using static System.Console;
using Exemplo1;


WriteLine("Entre com os dados do produto: ");
Write("Nome: ");
string nome = ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade: ");
int qtd = int.Parse(ReadLine());

Produto p = new Produto(nome, preco, qtd);

WriteLine($"Dados do produto: {p.dadospro()}");

Write("Digite a quantidade do produto a ser adionado no estoque: ");
qtd = int.Parse(ReadLine());
p.adipro(qtd);
WriteLine($"Dados atulizado: {p.dadospro}");
Write("Digite a quantidade de produto  a ser removido do estoque: ");
qtd = int.Parse(ReadLine());
p.remopro(qtd);
WriteLine($"Dados atulizado: {p.dadospro}");

ReadKey();
