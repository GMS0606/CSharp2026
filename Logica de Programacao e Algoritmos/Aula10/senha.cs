using static System.Console;
//declaração 
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//entrada
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//processamento
while (senha != SENHAFIXA)
{
    if (contagem >= 3)
    {
    WriteLine("Acesso bloqueado :( ");
    break;
    }
    contagem++;
    Write("Senha incorreta, digite novamente:  ");
    senha = int.Parse(ReadLine());
    
}
if (contagem < 3)
{
WriteLine("Acesso permitido! ;) ");
}
else  
{
    WriteLine("espere 20 minutos para um nova tentativa! ");
}
