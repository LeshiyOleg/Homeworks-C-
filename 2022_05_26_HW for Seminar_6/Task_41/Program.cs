﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// ```
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// ```

int[] GetSomeNumbers(int amountOfNum)
{
    Console.Write($"Введите {amountOfNum} чисел: ");
    int[] array = new int[amountOfNum];
    for (int i = 0; i < amountOfNum; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        //Console.Write($", ");
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.WriteLine($"{arrayToPrint[arrayToPrint.Length - 1]}");
}

int CalcPositiveNumbers(int[] arrayToCalc)
{
    int count = 0;
    for(int i=0; i<arrayToCalc.Length;i++)
    {
        if (arrayToCalc[i] > 0)
        count = count + 1;
    }
    return count;
}

Console.Write("Введите количество чисел для сортировки: ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
amountOfNumbers = Math.Abs(amountOfNumbers);

int[] enteredNumbers = GetSomeNumbers(amountOfNumbers);
Console.Write($"Вы ввели следующие числа для сортировки: ");
PrintArray(enteredNumbers);
Console.Write($"Количество положительных введенных чисел: {CalcPositiveNumbers(enteredNumbers)}");