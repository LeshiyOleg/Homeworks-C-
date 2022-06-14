// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ```
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// ```

int FindSumFromMToN(int m, int n)
{
    int result = n;
    if (m > n)
    {
        result = result + FindSumFromMToN(m, n + 1);
    }
    else if (m < n)
    {
        result = result + FindSumFromMToN(m, n - 1);
    }
    return result;
}

Console.Write("Введите натуральное число M (первое слагаемое): ");
int firstM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N (последнее слагаемое): ");
int lastN = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers = FindSumFromMToN(firstM, lastN);
Console.WriteLine($"Сумма чисел от {firstM} до {lastN} составляет {sumOfNumbers}");
