// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// ```
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// ```

int SumOfDigitsInNumber (int num)
{
    int result = 0;
    while (num>0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int digitsSum = SumOfDigitsInNumber (number);
Console.WriteLine($"Сумма цифр в числе: {digitsSum}");