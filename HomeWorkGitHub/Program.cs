// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* Console.WriteLine("Введите пятизначное число");
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
} */

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

/* Console.WriteLine("Введите координату X1 ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1 ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2 ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2 ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X3 ");
int x3 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y3 ");
int y3 = int.Parse(Console.ReadLine());

double distance = Math.Pow((Math.Pow(y1 - x1, 2) +
                         Math.Pow(y2 - x2, 2) +
                         Math.Pow(y3 - x3, 2) *
                                   1.0), 0.5);

Console.WriteLine("Distance is \n" + distance); */

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write(i*i*i + " ");
}