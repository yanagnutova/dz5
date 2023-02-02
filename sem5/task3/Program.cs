//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int InputIntArray(string message)
{
    Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


double[] CreateNumbersArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");
    }
}
double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальный элемент массива = {max:F2}");
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (min > array[j])
        {
            min = array[j];
        }
    }
    Console.WriteLine($"Минимальный элемент массива = {min:F2}");
    return min;
}


int amountOfElements = InputIntArray("Введите количтво элементов в массиве");
double[] array = new double[amountOfElements];
double[] numbersArray = CreateNumbersArray(array);
PrintArray(numbersArray);
double max = Max (array);
double min = Min (array);
double dif = max - min;
Console.WriteLine($"Разница между макс и мин элементом массива = {dif:F2}");