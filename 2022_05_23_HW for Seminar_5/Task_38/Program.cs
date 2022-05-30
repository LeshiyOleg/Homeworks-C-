// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// ```
// [3 7 22 2 78] -> 76
// ```

double[] GetRandomArray(int lengthArray, int upperBorder, int lowerBorder)
{
    double[] arrayToGet = new double[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        arrayToGet[i] = new Random().NextDouble() * upperBorder + lowerBorder;
    }
    return arrayToGet;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{Math.Round(arrayToPrint[i], 2)} ");
    }
    Console.WriteLine($"{Math.Round(arrayToPrint[arrayToPrint.Length - 1], 2)}]");
}

double FindDiffMaxMin(double[] arrayToFind)
{
    double max = arrayToFind[0];
    double min = arrayToFind[0];
    for (int i = 0; i < arrayToFind.Length; i++)
    {
        if(arrayToFind[i] > max)
        {
            max = arrayToFind[i];
        }
        if(arrayToFind[i] < min)
        {
            min = arrayToFind[i];
        }
    }
    return Math.Round(max - min,2);
}

Console.Write("Введите число элементов массива: ");
int elemnum = Convert.ToInt32(Console.ReadLine());

double[] array = GetRandomArray(elemnum, 10, -5);
Console.Write($"Заданный массив вещественных чисел из {elemnum} элементов: ");
PrintArray(array);
Console.Write($"Разность между максимальным и минимальным элементами массива: {FindDiffMaxMin(array)}");