// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// ```
// 456 -> 5
// 782 -> 8
// 918 -> 1
// ```
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int FirstDigit = number/100;
if (FirstDigit >0 & FirstDigit <10)
{
    int SecondDigit = (number - FirstDigit*100) / 10;
    Console.WriteLine("Вторая цифра числа: " + SecondDigit);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число! Повторите попытку.");
}

