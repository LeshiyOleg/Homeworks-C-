// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Get2DArray(int raws, int columns, int deviation)
{
    int[,] array2D = new int[raws, columns];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindSumsOfEveryString(int[,] arrayToFind)
{
    int[] resultArray = new int[arrayToFind.GetLength(0)];
    for (int i = 0; i < arrayToFind.GetLength(0); i++)
    {
        resultArray[i] = 0;
        for (int j = 0; j < arrayToFind.GetLength(1); j++)
        {
            resultArray[i] = resultArray[i] + arrayToFind[i, j];
        }
    }
    return resultArray;
}

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.WriteLine($"Сумма элементов в строке [{i}]: {arrayToPrint[i]} \t");
    }
    Console.WriteLine();
}

int FindPosOfMinElement(int[] arrayToFind)
{
    int minIndex = 0;
    for (int i = 1; i < arrayToFind.Length; i++)
    {
        if (arrayToFind[i] < arrayToFind[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

Console.Write("Введите количество строк массива: ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = Get2DArray(raws, columns, 9);
Console.WriteLine("Заданный массив: ");
Print2DArray(array2D);
Console.WriteLine();

int[] SumsOfStrings = FindSumsOfEveryString(array2D);
PrintArray(SumsOfStrings);

int minElemInd = FindPosOfMinElement(SumsOfStrings);
Console.WriteLine($"Наименьшая сумма элементов находится в cтроке с индексом [{minElemInd}] и составляет {SumsOfStrings[minElemInd]}");
