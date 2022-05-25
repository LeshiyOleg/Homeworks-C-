// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// ```
// [345, 897, 568, 234] -> 2
// ```

void GetRandomArray(int[] arrayToGet)
{
    for (int i = 0; i < arrayToGet.Length; i++)
    {
        arrayToGet[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.WriteLine($"{arrayToPrint[arrayToPrint.Length - 1]}]");
}

int FindEvenAmount(int[] arrayToFind)
{
    int count = 0;
    for (int i = 0; i < arrayToFind.Length; i++)
    {
        if (arrayToFind[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите число элементов массива: ");
int elemnum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemnum];
GetRandomArray(array);
Console.Write($"Заданный массив из {elemnum} элементов: ");
PrintArray(array);
Console.Write($"Количество четных элементов в массиве: {FindEvenAmount(array)}");