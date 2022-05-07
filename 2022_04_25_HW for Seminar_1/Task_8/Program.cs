/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
```
5 -> 2, 4
8 -> 2, 4, 6, 8
```
*/

Console.Write ("Введите число больше 1: ");
int number = Convert.ToInt32 (Console.ReadLine ());
if (number > 1)
{
    Console.Write ("Четные числа диапазона от 1 до " + number + ": ");
    for (int i = 2; i <= number; i = i + 2)
    {
        if (i < number-1)
        {
            Console.Write (i + ", ");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Введите корректное число");
}