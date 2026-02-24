using static System.Console;

double produto, quantidade, dinheiro, pagar, troco;

Write("Digite o preço do produto: ");
produto = double.Parse(ReadLine());
Write("Digite a quantidade do produto: ");
quantidade = double.Parse(ReadLine());
Write("Digite o valor em dinheiro: ");
dinheiro = double.Parse(ReadLine());

pagar = produto * quantidade;
troco = dinheiro - pagar;

WriteLine($"O troco a ser recebido é de: {troco}$");



