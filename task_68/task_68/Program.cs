int GetArray(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return GetArray(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return GetArray(m - 1, GetArray(m, n - 1));
    }
    else
        return n + 1;
}
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int c = GetArray(m, n);
Console.WriteLine(c);