//          Задача 2
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max ->" + a);
    Console.WriteLine("min ->" + b);
}
else
{
    Console.WriteLine("max ->" + b);
    Console.WriteLine("min ->" + a);
}