// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ```
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// 5 -> 9
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

void FindElemByPosition(int[,] arrayToSearch, int pos)
{
    if (pos >= 0 && pos < arrayToSearch.GetLength(0) * arrayToSearch.GetLength(1))
    {
        int elemRaw = pos / arrayToSearch.GetLength(1);
        int elemCol = pos - elemRaw * arrayToSearch.GetLength(1);
        int element = arrayToSearch[elemRaw, elemCol];
        Console.WriteLine($"Значение элемента с позицией [{pos}] в заданном массиве: {element}");
    }
    else
    {
        MakeChoiceToFindAgain(arrayToSearch, 2);
    }
}

void MakeChoiceToFindAgain(int[,] arr, int countValue)  // Метод, отвечающий за возможность повторного ввода данных
{
    Console.WriteLine("Заданный двумерный массив не содержит элемента с указанной позицией. Повторить поиск?");
    int count = 0;
    while (count < countValue)
    {
        Console.Write("Для нового поиска нажмите клавишу [Y], для выхода нажмите [Q]: ");
        string? answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
            Console.Write("Введите новую позицию элемента в двумерном массиве: ");
            int newPosition = Convert.ToInt32(Console.ReadLine());
            if (newPosition >= 0 && newPosition < arr.GetLength(0) * arr.GetLength(1))
            {
                FindElemByPosition(arr, newPosition);
                break;
            }
            count = count + 1;
        }
        else if (answer.ToLower() == "q")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы вышли из программы поиска. До новых встреч!)");
            Console.ResetColor();
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели неверную клавишу. Используйте для ответа клавиши [Y] или [Q]!!!");
            Console.ResetColor();
            count = count + 1;
        }
    }
    if (count == countValue)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы превысили максимальное количество попыток поиска. В следующий раз вводите корректное значение.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Подсказка_1. Значение позиции для данного количества строк и столбцов должно быть в диапазоне от 0 до {arr.GetLength(0) * arr.GetLength(1) - 1} (строки [{arr.GetLength(0)}] * столбцы [{arr.GetLength(1)}] - 1)!");
        Console.WriteLine("Подсказка_2. Для ответа на запрос повторного поиска используйте только клавиши [Y] или [Q]");
        Console.ResetColor();
    }
}

Console.Write("Введите количество строк массива: ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = Get2DArray(raws, columns, 10);
Console.WriteLine("Заданный массив: ");
Print2DArray(array);

Console.Write("Введите позицию элемента в двумерном массиве: ");
int position = Convert.ToInt32(Console.ReadLine());

FindElemByPosition(array, position);
