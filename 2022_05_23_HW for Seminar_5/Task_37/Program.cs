// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// ```
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// ```

void GetRandomArray(int[] arrayToGet)
{
    for (int i = 0; i < arrayToGet.Length; i++)
    {
        arrayToGet[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    Console.WriteLine($"{arrayToPrint[arrayToPrint.Length - 1]}]");
}

int[] FindMultPairs(int[] arrayToFind)
{
    int[] resArray = new int[(arrayToFind.Length + 1) / 2];
    for (int i = 0; i < arrayToFind.Length / 2; i++)
    {
        resArray[i] = arrayToFind[i] * arrayToFind[arrayToFind.Length - 1 - i];
        if (i <= resArray.Length - 1)
        {
            Console.Write($"{resArray[i]} ");
        }
        else
        {
            Console.Write($"{resArray[i]}");
        }
    }
    if (arrayToFind.Length % 2 == 1)
    {
        resArray[(arrayToFind.Length - 1) / 2] = arrayToFind[(arrayToFind.Length - 1) / 2];
        Console.Write($"{resArray[(arrayToFind.Length - 1) / 2]}");
    }
    return resArray;

}


Console.Write("Введите число элементов массива: ");
int elemnum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemnum];
GetRandomArray(array);
Console.Write($"Заданный массив из {elemnum} элементов: ");
PrintArray(array);
Console.Write($"Массив из результатов произведения парных элементов: ");
FindMultPairs(array);