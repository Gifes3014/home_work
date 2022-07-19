//          Задача 10
int a = int.Parse(Console.ReadLine());
if ((a > 99) & (a < 1000))
{
    a = (a - a / 100 * 100 - a % 10) / 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("error");
}