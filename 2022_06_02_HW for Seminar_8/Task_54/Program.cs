// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortStringsMaxToMin(int[,] arrayToSort)
{
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1)-1; j++)
        {
            for (int k = 1; k < arrayToSort.GetLength(1); k++)
        {
            if (arrayToSort[i, k] > arrayToSort[i, k - 1])
            {
                int temp = arrayToSort[i, k];
                arrayToSort[i, k] = arrayToSort[i, k - 1];
                arrayToSort[i, k - 1] = temp;
            }
        }
        }
    }
    return arrayToSort;
}



Console.Write("Введите количество строк массива: ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = Get2DArray(raws, columns, 9);
Console.WriteLine("Заданный массив: ");
Print2DArray(array2D);
Console.WriteLine();

int[,] sortedArray = SortStringsMaxToMin(array2D);
Console.WriteLine("Отсортированный массив по убыванию элементов в строке: ");
Print2DArray(sortedArray);

