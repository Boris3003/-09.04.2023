// third figure
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if(N>=1000)
{
    while(N>=1000)
    {
        N=N/10;
    }
N=N%10;
Console.Write($"Третья цифра числа равна  {N}");
}
else
Console.Write("Третьей цифры нет");