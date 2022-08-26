int GetArray(int a, int b)
{
    int k = b;
    int result = 0;
    for (int i = 0; i < a - b + 1; i++)
    {
        result += k;
        k++;
    }
    return result;
}
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int c = GetArray(m, n);
 Console.WriteLine(c);
