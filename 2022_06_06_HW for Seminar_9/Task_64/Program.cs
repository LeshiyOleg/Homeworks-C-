// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// ```
// M = 5; N = 1. -> "5, 4, 3, 2, 1"
// M = 8; N = 4. -> "8, 7,6, 5, 4"
// ```

void PrintFromMToNDown(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{m}, ");
        PrintFromMToNDown(m - 1, n);
    }
    else
        Console.Write(n);
}

void PrintFromMToNUp(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        PrintFromMToNUp(m + 1, n);
    }
    else
        Console.Write(n);
}

Console.Write("Введите натуральное число M (начало отсчета): ");
int startM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N (конец отсчета): ");
int finishN = Convert.ToInt32(Console.ReadLine());

if (startM > finishN)
{
    PrintFromMToNDown(startM, finishN);
}
else if (startM < finishN)
{
    PrintFromMToNUp(startM, finishN);
}
else
{
    Console.WriteLine(startM);
}