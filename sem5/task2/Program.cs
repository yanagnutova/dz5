//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
        array[i] = rnd.Next(-50, 50);
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

int SummNechet(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Cумма элементов на нечетных позициях = {summ}");
    return summ;
}


int amountOfElements = InputIntArray("Введите количтво элементов в массиве");
int[] array = new int[amountOfElements];
int[] numbersArray = CreateNumbersArray(array);
PrintArray(numbersArray);
int summNech = SummNechet (array);