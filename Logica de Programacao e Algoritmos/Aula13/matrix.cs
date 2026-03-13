using static System.Console;
int [,] matriz = new int [3,3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Digite o valor da posição [{i},{j}]:");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}
WriteLine ("Matriz preenchida: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write(matriz [i , j] + "\t");
    }
    WriteLine();
}