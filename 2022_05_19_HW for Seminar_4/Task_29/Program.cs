// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// ```
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
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

Console.Write("Введите число элементов массива: ");
int elemnum = Convert.ToInt32(Console.ReadLine());

int [] array = new int [elemnum];
GetRandomArray (array);
Console.Write($"Заданный массив из {elemnum} элементов: ");
PrintArray(array);