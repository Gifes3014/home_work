//          Задача 27
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a);
int c = 0;
for(int i = 0; i < b.Length; i++)
{
    c = c + b[i] - 48;
}
Console.WriteLine(c);