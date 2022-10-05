// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


double FindPointX(double b1, double b2, double k1, double k2)
{
    double x = 0;
    x = (b1 - b2) / (k2 - k1);
    return x;
}

double FindPointY(double x, double k2, double b2)
{
    double y = 0;
    y = k2 * x + b2;

    return y;
}

double b1 = GetNumber("Введите координату b1");
double k1 = GetNumber("Введите координату k1");
double b2 = GetNumber("Введите координату b2");
double k2 = GetNumber("Введите координату k2");


double numberX = FindPointX(b1, b2, k1, k2);
double numberY = FindPointY(numberX, k2, b2);

Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");