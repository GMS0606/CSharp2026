using static System.Console;

double alturaMA, alturaMI;
int pessoa, visitantesok = 0, visitantenaook= 0;
try
{

    Write("Digite a quantidade de pessoas? ");
    pessoa = int.Parse(ReadLine());

    Write("Digite a altura maxima? "); 
    alturaMA = double.Parse(ReadLine());

    Write("Digite a altura minima? "); 
    alturaMI = double.Parse(ReadLine());

    for (int i = 0; i <pessoa; i++)
{
     Write($"digite a altura da pessoa {i+1} : ");
    double altura = double.Parse(ReadLine());

        if (altura >= alturaMI & altura <= alturaMA)
        {
            visitantesok++;
        }
        else if (altura < alturaMI)
        {
            visitantenaook++;
        }
        else
        {
            visitantenaook++;
        }
}
WriteLine ($"{visitantesok} pessoas que estão entre {alturaMI} e {alturaMA} cm de altura :) ");
WriteLine ($"{visitantenaook} pessoas que não estão entre {alturaMI} e {alturaMA} cm de altura :( ");
}
catch (Exception ex)
{
    
    WriteLine($"Valor invalido, erro =, {ex.Message}");
}