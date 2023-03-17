// Задача 19 - HARD необязательная.
//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой. 

Console.WriteLine("input number:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
Size(num);
int[] array = new int[count];
int res = 0;

for(int i = 0; i < count; i++)
    {
        array[i] = num % 10;
        num /= 10;
    }
for(int j = 0; j < count; j++)
{
    res += array[j] - array[count-1];
    count = count - 1;
}
if (res == 0)
    Console.WriteLine("its a palindrom");
else
    Console.WriteLine("its a not palindrom");

int Size(int num)
{
    while(num >= 1)
    {
        num /= 10;
        count++; 
    }
    return count;
}