// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// ```
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// ```

double FindDist3D (int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ));
    result = Math.Round(result, 2);
    return result;
}

Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("Введите координату X точки А");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
int ZpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("Введите координату X точки B");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double distance = FindDist3D (XpointA, YpointA, ZpointA, XpointB, YpointB, ZpointB);

Console.WriteLine($"Расстояние между точками A и B равняется: {distance}");