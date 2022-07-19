//          Задача 15
int a = int.Parse(Console.ReadLine());
if ((a >= 1) & (a <= 5))
{
    Console.WriteLine("да");
}
else if ((a == 6) ^ (a == 7))
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("ошибка");
}