using Funcionario;
using static System.Console;

WriteLine("Digite o nome do funcionario:");
string nome = ReadLine();

WriteLine("Digite o salário bruto do funcionario:");
double salariobruto = double.Parse(ReadLine());

WriteLine("Digite o valor total de imposto a ser pago pelo funcionario:");
double imposto = double.Parse(ReadLine());
WriteLine();

// Criando objeto
Desconto p = new Desconto(nome, salariobruto, imposto);

// Exibindo dados
WriteLine("Dados do funcionario:");
p.dadofun();

WriteLine();
WriteLine();

WriteLine("Digite a quantidade de aumento de salario do funcionario:");
double porcentagem = double.Parse(ReadLine());

// Aplicando aumento
p.aumentarsalario(porcentagem);

// Exibindo dados atualizados
WriteLine("Dados do funcionario atualizado:");
p.dadofun();