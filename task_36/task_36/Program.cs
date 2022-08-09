int num = 0;
int k = 0;
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
foreach (int item in GetArray(10, -9, 9))
{
    k++;
    Console.WriteLine(item);
    num += k % 2 == 0 ? item : 0;
}
Console.WriteLine("-> "+num);