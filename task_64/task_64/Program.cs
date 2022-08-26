int[] GetArray(int a, int b)
{
    int k = b;
    int[] result = new int[a - b + 1];
    for (int i = 0; i < a - b + 1; i++)
    {
        result[i] = k;
        k++;
    }
    return result;
}
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int[] c = GetArray(m, n);
foreach (int item in c)
{
    Console.WriteLine(item);
}