// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// ```
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// ```

void GetRandomArray(int[] arrayToGet)
{
    for (int i = 0; i < arrayToGet.Length; i++)
    {
        arrayToGet[i] = new Random().Next(-99, 100);
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

int FindSumOddPos(int[] arrayToFind)
{
    int count = 0;
    for (int i = 1; i < arrayToFind.Length; i+=2)
    {
        count += arrayToFind[i];
    }
    return count;
}

Console.Write("Введите число элементов массива: ");
int elemnum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemnum];
GetRandomArray(array);
Console.Write($"Заданный массив из {elemnum} элементов: ");
PrintArray(array);
Console.Write($"Сумма элементов массива на нечетных позициях: {FindSumOddPos(array)}");