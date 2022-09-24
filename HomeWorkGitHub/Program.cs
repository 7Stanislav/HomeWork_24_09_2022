// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if ((number > 99999) || (number < 10000))
{
    Console.WriteLine("Число должно быть пятизначным");
}
else
{

    int num1 = (number / 10000);
    int num2 = (number % 10000 / 1000);
    int num3 = (number % 1000 / 100);
    int num4 = (number % 100 / 10);
    int num5 = (number % 10);
    
    if ((num1 == num5) && (num2 == num4))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}