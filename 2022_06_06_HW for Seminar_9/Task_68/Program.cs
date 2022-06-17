// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// ```
// m = 2, n = 3 -> A(m,n) = 9
// ```

int FindAckermann(int m, int n)
{
    int result = 0;
    if (m == 0)
    {
        result = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        result = FindAckermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        result = FindAckermann(m - 1, FindAckermann(m, n - 1));
    }
    return result;
}

Console.Write("Введите значение m функции Аккермана: ");
int mAcker = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n функции Аккермана: ");
int nAcker = Convert.ToInt32(Console.ReadLine());

int ackermann = FindAckermann(mAcker, nAcker);
Console.WriteLine($"Значение функции Аккермана A(m,n) для m = {mAcker}, n = {nAcker} равняется {ackermann}");
