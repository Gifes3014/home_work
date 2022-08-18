int[,,] GetArray(int n, int m,int h, int min, int max)
{
    int a = 0;
    int b = 0;
    int[,,] result = new int[m, n, h];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int f = 0; f < h; f++)
            {
                result[i, j, f] = new Random().Next(min, max);
            }
            
        }
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int f = 0; f < h; f++)
            {
                a = result[i, j, f];
                for (int q = 0; q < m; q++)
                {
                    for (int w = 0; w < n; w++)
                    {
                        for (int e = 0; e < h; e++)
                        {
                            b = result[q, w, e];
                            if ((a == b) & (i != q) & (j != w) & (f != e))
                            {
                                result[q, w, e] = new Random().Next(min, max);
                                i = 0;
                                j = 0;
                                f = 0;
                                q = 0;
                                w = 0;
                                e = 0;
                            }
                        }
                    }
                }
            }

        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int f = 0; f < inArray.GetLength(2); f++)
            {
                Console.Write(inArray[i, j, f] + " (" + i + j + f + ") ");
            }
        }
        Console.WriteLine();
    }
}
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine());
int[,,] array = GetArray(x, y, z, 10, 99);
PrintArray(array);