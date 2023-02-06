//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int InputIntArray(string message)
{
    Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int[] CreateNumbersArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int PositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    Console.WriteLine($"Количество положительных элементов {count}");
    return count;
}

int elements = InputIntArray("Введите количество элементов в массиве");
int[] array = new int[elements];
int[] numbersArray = CreateNumbersArray(array);
int pos = PositiveNumbers(array);

