Console.Write("Введдите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введдите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введдите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введдите b2: ");
double b2 = double.Parse(Console.ReadLine());
double[] GetXY(double x1, double y1, double x2, double y2)
{
    double[] yx = new double[2];
    yx[0] = (b2 - b1) / (k1 - k2);
    yx[1] = k2 * yx[0] + b2;
    return yx;
}
double[] xy = GetXY(k1,b1,k2,b2);
Console.Write(xy[0]+ " "+xy[1]);