// Задача 21 - HARD необязательная
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
//Сначала задается N с клавиатуры, потом задаются координаты точек.
// Проверка для 3х-мерного пространства:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Input space dimension:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[N];
int[] array2 = new int[N];

for(int i = 0; i < N; i++)
{
    Console.WriteLine($"Input coordinate x{i+1} for First Point:  ");
    int coord1 = Convert.ToInt32(Console.ReadLine());
    array1[i] = coord1;
}
for(int j = 0; j < N; j++)
{
    Console.WriteLine($"Input coordinate y{j+1} for Second Point:  ");
    int coord2 = Convert.ToInt32(Console.ReadLine());
    array2[j] = coord2;
}

Console.WriteLine($"distance = {distance(array1, array2)}");

double distance(int []array1, int []array2)
{
    double res1 = 0;
    for(int k = 0; k < N; k++)
        res1 += Math.Pow((array2[k]-array1[k]), 2);
    double result = Math.Round(Math.Sqrt(res1), 2, MidpointRounding.AwayFromZero);
    return result;
}