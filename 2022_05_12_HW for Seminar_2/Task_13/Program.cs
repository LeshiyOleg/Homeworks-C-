// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ```
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// ```
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//string numberStr = Convert.ToString(number); // - пробовал проверять запись числа, если начинается на ноль - выдавать ошибку, 
// НО!!! при конвертации числа в строку первые нули исчезают!

//if (numberStr[0] != '0')
//{
    if (number > 99)
    {
        int number3Digits = number;
        for (int i = 10; number3Digits > 99;)
        {
            if (number3Digits / i < 100)
            {
                Console.WriteLine($"Третья цифра числа: {number3Digits % 100 % 10}");
                break;
            }
            else
            {
                number3Digits = number3Digits / i;
            }
        }
    }
    else
    {
        Console.WriteLine("У введенного числа третьей цифры нет");
    }
//}

// else
// {
//     Console.WriteLine("Введите число, которое не начинается на ноль!");
// }

// Console.WriteLine($"Первое число строки numberStr {numberStr[0]}"); //- проверка первой цифры числа, преобразованного в строку