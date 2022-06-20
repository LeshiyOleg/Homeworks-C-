// Задача 72: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления
//  нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, 
//  которые занимают числа из массива data. Напишите программу, которая составит массив десятичных 
//  представлений чисел массива data с учётом информации из массива info.
// ```
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1
// ```

int[] GetBinaryArray(int size)
{
    int[] binArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        binArray[i] = new Random().Next(0, 2);
    }
    return binArray;
}

int[] GetBitsArray(int size)
{
    List<int> bitsList = new List<int>();
    Console.WriteLine($"Введите по порядку несколько чисел, обозначающих количество бит, занимаемых в массиве *data*");
    int filledPos = 0;
    while (filledPos < size)
    {
        Console.Write($"Введите количество бит меньше или равное {size - filledPos}: ");
        int newNum = Convert.ToInt32(Console.ReadLine());
        if (filledPos + newNum > size)
        {
            Console.WriteLine("Введите корректное значение!");
        }
        else
        {
            bitsList.Add(newNum);
            filledPos += newNum;
        }
    }
    int[] arrayOfBits = bitsList.ToArray();
    return arrayOfBits;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("{");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.WriteLine($"{arrayToPrint[arrayToPrint.Length - 1]}}}");
}

int[] GetDecimalNumbers(int[] binaryArr, int[] bitsArr)
{
    int[] decimalNumbers = new int[bitsArr.Length];
    int startPos = 0;
    for (int j = 0; j < bitsArr.Length; j++)
    {
        decimalNumbers[j] = 0;
        int powerValue = bitsArr[j] - 1;

        for (int i = startPos; i < startPos + bitsArr[j]; i++, powerValue--)
        {
            decimalNumbers[j] += binaryArr[i] * GetAToPowerN(2, powerValue);
        }
        startPos += bitsArr[j];
    }
    return decimalNumbers;
}


int GetAToPowerN(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return GetAToPowerN(a, n - 1) * a;
    }
}


Console.Write("Введите размерность массива *data* с двоичным представлением чисел: ");
int sizeData = Convert.ToInt32(Console.ReadLine());

int[] dataArray = GetBinaryArray(sizeData);

Console.WriteLine("Введите с клавиатуры массив *info* с информацией о количестве бит: ");
int[] infoArray = GetBitsArray(sizeData);

Console.WriteLine();
Console.Write($"Массив с двоичным представлением чисел data = ");
PrintArray(dataArray);
Console.Write($"Массив с информацией о количестве бит  info = ");
PrintArray(infoArray);

int[] decArray = GetDecimalNumbers(dataArray, infoArray);
Console.Write($"Массив с десятичным представлением чисел    = ");
PrintArray(decArray);

