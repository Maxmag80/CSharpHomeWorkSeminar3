// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("input 5-digital number:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];

if((num / 10000) < 1 || (num / 10000) > 10)
    Console.WriteLine("Please, input only 5-digital number");
else
{
    for(int i = 0; i < 5; i++)
    {
        array[i] = num % 10;
        num /= 10;
    }
    
    if (array[0]==array[4] && array[1]==array[3])
        Console.WriteLine("its a palindrom");
    else
        Console.WriteLine("its a not palindrom");
}