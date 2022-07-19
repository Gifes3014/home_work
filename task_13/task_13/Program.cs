//          Задача 13
int a = int.Parse(Console.ReadLine());
if (a > 99)
{
    string b = Convert.ToString(a);
    Console.WriteLine(b[b.Length - (b.Length - 2)]);
}
else
{
    Console.WriteLine("нет 3 цифры");
}