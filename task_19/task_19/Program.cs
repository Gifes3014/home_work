//          Задача 19
int a = int.Parse(Console.ReadLine());
if ((a > 9999) & (a < 100000))
{
    string b = Convert.ToString(a);
    if ((b[0] == b[4]) & (b[1] == b[3]))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
   
}
else
{
    Console.WriteLine("ошибка");
}
