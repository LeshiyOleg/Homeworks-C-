// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// ```
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// ```

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

double[] FindArithMean(int[,] arrayToFind)
{
    double[] result = new double[arrayToFind.GetLength(1)];
    for (int j = 0; j < arrayToFind.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < arrayToFind.GetLength(0); i++)
        {
            result[j] = result[j] + arrayToFind[i, j];
        }
        result[j] = result[j] / arrayToFind.GetLength(0);
    }
    return result;
}

void PrintArray(double[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{Math.Round(arrayToPrint[i],1)} \t");
    }
    Console.WriteLine();
}


Console.Write("Введите количество строк массива: ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = Get2DArray(raws, columns, 9);
Console.WriteLine("Заданный массив: ");
Print2DArray(array2D);
Console.WriteLine();

double[] array = FindArithMean(array2D);

Console.WriteLine("Среднеарифметическоие значения по столбцам:");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(array);
Console.ResetColor();