/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double GetNumber(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine() ?? "");
    return number;
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = ((b2 - b1) / (k1 - k2));
    double y = k1 * x + b1;

    if (k1 != k2)
        Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
    if (b1 == b2 && k1 == k2)
        Console.WriteLine($"Прямые совпадают");
    if (b1 != b2 && k1 == k2)
        Console.WriteLine($"Прямые паралельны");
}

double b1 = GetNumber("Введите значение b1: ");
double k1 = GetNumber("Введите значение k1: ");
double b2 = GetNumber("Введите значение b2: ");
double k2 = GetNumber("Введите значение k2: ");
IntersectionPoint(b1, k1, b2, k2);
