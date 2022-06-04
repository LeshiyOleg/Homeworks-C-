// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ```
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// ```

double[,] Get2DArray(int raws, int columns, int deviation)
{
    double[,] array2D = new double[raws, columns];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = new Random().NextDouble() * 2 * deviation - deviation;
        }
    }
    return array2D;
}

void Print2DArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arrayToPrint[i, j], 1)} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива m = ");
int mRaws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n = ");
int nColumns = Convert.ToInt32(Console.ReadLine());

double[,] array = Get2DArray(mRaws, nColumns, 10);
Print2DArray(array);