using static System.Console;

int n = 0;

do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait();


}while (n < 6);
WriteLine(" FIM DO PROGRAMA 1 :) ");

n = 0;
while (n < 6)
{
    Write(n);
    n++;
    Task.Delay(1000).Wait();
}
WriteLine(" FIM DO PROGRAMA 2 :) ");