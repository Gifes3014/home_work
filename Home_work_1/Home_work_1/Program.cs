//          Задача 2
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("max ->" + a); 
//    Console.WriteLine("min ->" + b);
//}
//else
//{
//    Console.WriteLine("max ->" + b);
//    Console.WriteLine("min ->" + a);
//}

//          Задача 4
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if ((a > b) & (a > c))
//{
//    Console.WriteLine("max ->" + a);
//}
//else if ((b > a) & (b > c))
//{
//    Console.WriteLine("max ->" + b);
//}
//else if ((c > a) & (c > b))
//{
//    Console.WriteLine("max ->" + c);
//}

//          Задача 6
//int a = int.Parse(Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine("чётное");
//}
//else
//{
//    Console.WriteLine("не чётное");
//}

//          Задача 8
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
