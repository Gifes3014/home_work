int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
int[,] GetArray_2(int n, int m, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
int[,] GetArray_3(int[,] arr, int[,] arr_2, int n, int m)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = arr[i, j] * arr_2[i, j];
        }
    }
    return result;
}
void PrintArray_1(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
int[,] array_2 = GetArray_2(rows, columns, 0, 9);
int[,] array_3 = GetArray_3(array, array_2, rows, columns);
PrintArray_1(array);
Console.WriteLine();
PrintArray_1(array_2);
Console.WriteLine();
PrintArray_1(array_3);