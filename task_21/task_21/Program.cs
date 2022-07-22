//          Задача 21
int x_1 = int.Parse(Console.ReadLine());
int y_1 = int.Parse(Console.ReadLine());
int z_1 = int.Parse(Console.ReadLine());
int x_2 = int.Parse(Console.ReadLine());
int y_2 = int.Parse(Console.ReadLine());
int z_2 = int.Parse(Console.ReadLine());

double D(int x_1L, int y_1L,int z_1L, int x_2L, int y_2L, int z_2L)
{
    double D_0 = Math.Sqrt(Math.Pow((x_2L - x_1L), 2) + Math.Pow((y_2L - y_1L), 2) + Math.Pow((z_2L - z_1L), 2));
    return D_0;
}

Console.WriteLine(D(x_1, y_1, z_1, x_2, y_2, z_2));

//A(3, 6, 8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53