// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Get2DArray(int raws, int columns, int deviation)
{
    int[,] array2D = new int[raws, columns];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = new Random().Next(0, deviation + 1);
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

void GetMultOfMatrix(int[,] matrixToMult1, int[,] matrixToMult2)
{
    int[,] result = new int[matrixToMult1.GetLength(0), matrixToMult2.GetLength(1)];
    if (matrixToMult1.GetLength(1) == matrixToMult2.GetLength(0))
    {

        for (int i = 0; i < matrixToMult1.GetLength(0); i++)
        {
            for (int j = 0; j < matrixToMult2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrixToMult1.GetLength(1); k++)
                {
                    result[i, j] = result[i, j] + matrixToMult1[i, k] * matrixToMult2[k, j];
                }

            }
        }
        Console.WriteLine("Результат умножения Матрицы 1 на Матрицу 2:");
        Print2DArray(result);
    }
    else
    {
        Console.WriteLine("Количество столбцов Матрицы 1 должно быть равным количеству строк Матрицы 2");
    }


}

Console.Write("Введите количество строк 1-й матрицы: ");
int raws1Matrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-й матрицы: ");
int columns1Matrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2-й матрицы: ");
int raws2Matrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-й матрицы: ");
int columns2Matrix = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = Get2DArray(raws1Matrix, columns1Matrix, 5);
Console.WriteLine("Матрица 1: ");
Print2DArray(matrix1);
Console.WriteLine();

int[,] matrix2 = Get2DArray(raws2Matrix, columns2Matrix, 5);
Console.WriteLine("Матрица 2: ");
Print2DArray(matrix2);
Console.WriteLine();

GetMultOfMatrix(matrix1, matrix2);
