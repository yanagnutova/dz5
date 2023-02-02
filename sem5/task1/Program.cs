//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int InputIntArray(string message)
{
    Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


int[] CreateNumbersArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных элементов = {count}");
    return count;
}
int amountOfElements = InputIntArray("Введите количтво элементов в массиве");
int[] array = new int[amountOfElements];
int[] numbersArray = CreateNumbersArray(array);
PrintArray(numbersArray);
int evenEl = NumberOfEven(array);
