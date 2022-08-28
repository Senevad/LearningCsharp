Console.Clear();
Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("прямые паралельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"точка пересечения ({x},{y})");
}
