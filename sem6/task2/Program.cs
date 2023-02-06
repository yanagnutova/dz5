//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputCoef(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double FindX(double b1, double b2, double k1, double k2)
{
    double x = ((b2 - b1) / (k1 - k2));
    return x;
}

double FindY(double k1, double b1, double k2, double b2)
{
    double x = FindX(b1, b2, k1, k2);
    double y = (k1 * x + b1);
    return y;
}

bool Validate(double k1, double k2)
{
    if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны или совпадают");
        return false;
    }
    return true;
}

double b1 = InputCoef($"b1 = ");
double b2 = InputCoef($"b2 = ");
double k1 = InputCoef($"k1 = ");
double k2 = InputCoef($"k2 = ");

if (Validate(k1, k2))
{
    double resultX = FindX(b1, b2, k1, k2);
    double resultY = FindY(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения двух прямых {resultX}, {resultY} ");
}