// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// ```
// 6 -> да
// 7 -> да
// 1 -> нет
// ```

Console.Write("Введите цифру, соответствующую дню недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

if (daynumber < 1 || daynumber > 7)
{
    Console.WriteLine($"Введите день недели от 1 до 7!");
}
else
{
    switch (daynumber)
    {
        case <= 5:
            Console.WriteLine($"День недели под номером {daynumber} НЕ выходной");
            break;

        case >= 6:
            Console.WriteLine($"День недели под номером {daynumber} является выходным");
            break;
    }

}
