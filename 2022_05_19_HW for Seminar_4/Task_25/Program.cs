// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// ```
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// ```

double FindExpResult(int num, int exp)
{
    double res = 1;
    if (exp >= 0)
    {
        for (int i = 1; i <= exp; i++)
        {
            res = res * num;
        }
        return res;
    }
    else
    {
        for (int i = 1; i <= Math.Abs(exp); i++)
        {
            res = res / num;
        }
        return res;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int exponent = Convert.ToInt32(Console.ReadLine());

double result = FindExpResult(number, exponent);
Console.WriteLine($"Результат возведения числа {number} в степень {exponent}: {Math.Round(result, 4)}");