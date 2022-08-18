﻿int[,] GetArray(int n, int m, int min, int max)
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
int GetArray_2(int[,] arr, int n, int m)
{
    int x = 0;
    int k = 99999;
    int[] mass = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
                mass[i] += arr[i, j];
        }
    }
    for (int j = 0; j < n; j++)
    {
        if (k > mass[j])
        {
            x = j;
        }
    }
    return x;
}
void PrintArray_1(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
int array_2 = GetArray_2(array, rows, columns);
PrintArray_1(array);
Console.WriteLine("Hомер строки с наименьшей суммой элементов: " + array_2);
