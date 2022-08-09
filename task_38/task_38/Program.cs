double max = 0;
double min = 100;
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
foreach (int item in GetArray(10, 100, 9999))
{
    double num = Convert.ToDouble(item) / 100;
    Console.WriteLine(num);
    max = num > max ? num : max;
    min = num < min ? num : min;
}
Console.WriteLine("max -> " + max);
Console.WriteLine("min -> " + min);
Console.WriteLine(max - min);