//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("input integer positive number:");

try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if(num>0)
    {
        for(int i = 1; i <= num; i++)
        {
            int n = i*i*i;
            Console.Write($"{n}, ");
        }
    }
    else
        Console.WriteLine("mistake input");
}
catch
{
    Console.WriteLine("mistake input");
}
