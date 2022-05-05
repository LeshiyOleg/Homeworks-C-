/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
```
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
```
*/

Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Большее число = " + a);
}
else
{
    if (a < b)
    {
        Console.WriteLine("Большее число = " + b);
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
}