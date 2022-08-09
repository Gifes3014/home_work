int num = 0;
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
foreach (int item in GetArray(10, 100, 999))
{
    Console.WriteLine(item);
    num += item % 2 == 0 ? 1 : 0;
}
Console.WriteLine(num);