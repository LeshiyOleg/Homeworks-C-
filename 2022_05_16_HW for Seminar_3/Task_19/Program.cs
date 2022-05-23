// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// ```
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// ```

// Вариант 1 (очень просто if/else)

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number / 10000 >= 1 && number / 10000 <= 9)
// {
//     if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели НЕ пятизначное или отрицательнео число!");
// }


// Вариант 2 (универсальный)

int MakeDivider(int num) // создаем делитель, т.е. число той же разрядности, что и введенное. 10 в какой-то степент
{
    int result = 1;
    for (int i = 10; num >= 10;)
    {
        num = num / i;
        result *= 10;
    }
    return result;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int divider = MakeDivider(number);

while (number > 9)
{
    int leftNum = number / divider;                 // находим крайнюю левую цифру числа
    int rightNum = number % 10;                     // находим крайнюю правую цифру числа
    if (leftNum == rightNum)
    {
        number = number % divider / 10;
        divider = divider / 100;
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
        break;
    }
}

if (divider < 2)
{
    Console.WriteLine("Число является палиндромом");
}
