using static System.Console;

int ano, mes, dias, dia; 

Write("Digite o seu numero de dias: ");
dias = int.Parse(ReadLine());
ano = dias / 365; // divide os numero que o usuario passou por 365
mes = (dias%365) / 30; // divide o resto da primeria conta exemplo se sobrou 30 vai divir 30/30 = 1 
dia = (dias%365) % 30; // divide o reto do resto tipo se sobrou 1 vai dividir 1/30 
WriteLine($"O total de anos é:{ano}");
WriteLine($"O total de meses é: {mes} ");
WriteLine($"O total de dias é: {dia}");