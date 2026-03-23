using Funcionario;
using static System.Console;

Write("Digite o nome do funcionario: ");
string nome = ReadLine();

Write("Digite o salário bruto do funcionario: ");
double salariobruto = double.Parse(ReadLine());

Write("Digite o valor total de imposto a ser pago pelo funcionario: ");
double imposto = double.Parse(ReadLine());
WriteLine();

// Criando objeto
Desconto p = new Desconto(nome, salariobruto, imposto);

// Exibindo dados
WriteLine("Dados do funcionario:");
p.dadofun();

WriteLine();
WriteLine();

Write("Digite a quantidade de aumento de salario do funcionario: ");
double porcentagem = double.Parse(ReadLine());

WriteLine();
WriteLine($"Salario do funcionario aumentado em {porcentagem}%");
WriteLine();

// Aplicando aumento
p.aumentarsalario(porcentagem);

// Exibindo dados atualizados
WriteLine("Dados do funcionario atualizado:");
p.dadofun();