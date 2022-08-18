int[,] GetArray(int m)
{
    int[,] result = new int[m, m];
    int k = 1;
    for (int i = 0; i < m; i++)
    {
    result[0, i] = k;
    k++;
    }
    for (int i = 0; i < m - 1; i++)
    {
        result[i + 1, 3] = k;
        k++;
    }
    for (int i = 2; i > -1; i--)
    {
        result[3, i] = k;
        k++;
    }
    for (int i = 2; i > 0; i--)
    {
        result[i, 0] = k;
        k++;
    }
    for (int i = 1; i < 3; i++)
    {
        result[1, i] = k;
        k++;
    }
    result[2, 2] = k;
    k++;
    result[2, 1] = k;
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(4);
PrintArray(array);
Console.WriteLine();

