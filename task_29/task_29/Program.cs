//          Задача 29
int[] a = new int[8];
for (int i = 0; i < 8; i++)
{
    Random r = new Random();
    a[i] = r.Next(9);
}
var b = string.Join("",a);
Console.WriteLine(b);