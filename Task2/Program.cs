// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)), 2, MidpointRounding.AwayFromZero);
    return dist;
}
Console.WriteLine($"distance = {distance(x1, y1, z1, x2, y2, z2)}");