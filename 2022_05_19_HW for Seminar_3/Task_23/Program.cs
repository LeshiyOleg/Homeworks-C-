// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// ```
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// ```

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int cube = i * i * i;
    if (i < number)
    {
        Console.Write($"{cube}, ");
    }
    else
    {
        Console.Write(cube);
    }
}