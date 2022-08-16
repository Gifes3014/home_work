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
void PrintArray(int[,] inArray, int x, int y)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j]);
        }
        Console.WriteLine();
    }
    if (x >= inArray.GetLength(0) ^ y >= inArray.GetLength(1))
    {
        Console.Write("error");
    }
    else
    {
        Console.Write(inArray[x, y]);
    }
}
int rows = 3;
int columns = 3;
int rows_2 = int.Parse(Console.ReadLine());
int columns_2 = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array, rows_2, columns_2);