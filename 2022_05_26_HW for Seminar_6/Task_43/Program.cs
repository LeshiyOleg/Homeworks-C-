// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// ```
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
// ```

void PrintArray(double[] arrayToPrint)
{
    Console.Write("(");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{Math.Round(arrayToPrint[i], 2)}; ");
    }
    Console.WriteLine($"{Math.Round(arrayToPrint[arrayToPrint.Length - 1], 2)})");
}

void FindCrossPoint(double k1Par, double b1Par, double k2Par, double b2Par)
{
    if (k1Par != k2Par)
    {
        double x = (b2Par - b1Par) / (k1Par - k2Par);
        double y = k1Par * x + b1Par;
        double[] crossCoord = new double [] {x, y};
        Console.WriteLine();
        Console.Write("Координаты точки пересечения прямых: ");
        PrintArray(crossCoord);
    }
    else
    {
        Console.WriteLine("Прямые являются параллельными, поэтому точки пересечения нет");
    }
}

Console.WriteLine("Введите параметры k1 и b1 для уравнения прямой вида y = k1 * x + b1 :");
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры k2 и b2 для уравнения прямой вида y = k2 * x + b2 :");
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

FindCrossPoint(k1, b1, k2, b2);
