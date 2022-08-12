Console.Write("Введите колличество чисел которые хотите записать: ");
int m = int.Parse(Console.ReadLine());
int GetSum(int n)
{
    int r = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите число: " + i +" из "+ m+" ");
        int k = int.Parse(Console.ReadLine());
        r += k > 0 ? 1 : 0;
    }
    return r;
}
int s = GetSum(m);
Console.Write("Кол-во чисел больше 0: "+ s);