// day of week
Console.Write("Введите число от одного до семи, где 1 - понедельник, а 7 - воскресенье:  ");
int N = int.Parse(Console.ReadLine());
while (N<1 | N>7) 
{
    Console.Write("Вы ввели неверное значение. Пожалуйста введите число от 1 до 7:  ");
    int x = int.Parse(Console.ReadLine());
    N = x;
}
if (N<6) Console.Write("Это рабочий день");
else Console.Write("Это выходной день");