// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1, k1 и b2, k2 заданы

Console.Write("Введите b1 - ");
int b1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите b2 - ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите k1 - ");
int k1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите k2 - ");
int k2 = int.Parse(Console.ReadLine() ?? "0");

if (k1 == k2) Console.WriteLine("Точек пересечения нет, прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: x = {x}, y = {y}");
}
