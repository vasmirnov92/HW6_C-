// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)
Console.Clear();

double[] FindCross(double ugl1, double svob1, double ugl2, double svob2)
{
    double[] peresech = new double[2];
   // double y = 0;
    peresech[0] = (svob2-svob1)/(ugl1-ugl2);
    peresech[1] = ugl1*peresech[0]+svob1;
    return peresech;
}


Console.WriteLine("Программа по нахожденияю точки перечечения двух прямых формата y=kx+b");
Console.Write("Введите угловой коэффициент первой прямой: k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите свободный коэффициент первой прямой: b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите угловой коэффициент второй прямой: k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите свободный коэффициент второй прямой: b2 = ");
double b2 = double.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Линии совпадают");
}
else if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double[] teh = FindCross(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения двух прямых: ({String.Join(" ; ", teh)})");
}