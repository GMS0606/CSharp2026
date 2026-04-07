using Master;

/*

Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPJ);

Console.WriteLine();

 */


Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 40689710023));

var a = conta.ToString();
Console.WriteLine(a);

Console.WriteLine();

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("Cesar", 5197810010), 20000);

var b = pj.ToString();
Console.WriteLine(b);

Console.WriteLine();

Poupanca pp = new Poupanca(666666, 666.666, new Pessoa("Lu", 66666666666), 6);

pp.consulta();

Console.ReadKey();
 