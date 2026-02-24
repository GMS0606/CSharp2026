
using System.Diagnostics.Contracts;
using static System.Console; 

int a, b, c;

Write ("Digite o valor de A: ");
a = int.Parse(ReadLine());

Write ("Digite o valor de B: ");
b = int.Parse(ReadLine());

Write ("Digite o valor de C: ");
c = int.Parse(ReadLine());

bool valor1 = a == c;
bool valor2 = b != a; 
bool valor3 = b > c;
bool valor4 = a <= c;

WriteLine($"O primeiro valor é igual ao tercerio valor? {valor1}");
WriteLine($"O segundo valor é diferente do primeiro valor? {valor2}");
WriteLine($"O segundo valor é maior que o terceiro valor? {valor3}");
WriteLine($"O primeiro valor é menor ou igual o terceiro valor? {valor4}");

bool per1 = valor1 & valor3;

WriteLine($"O resultado da comparação entre a pergunta 1 e a pergunta 3 serem verdadeiros é: {per1}");

bool per2 = valor2 | valor4;

WriteLine($"O resultado da comparação entre a pergunta 2 e a pergunta 4 referente a pelo menos uma ser verdadeira é: {per2}");

bool per3 = !valor1;

WriteLine($"O resultado da comparação se a negação da primeria pergunta é verdadeira: {per3}");
