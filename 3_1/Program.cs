// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine()!);
if (a > 99999 || a < 10000)
Console.WriteLine("Введено не пятизначное число");
else if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10)
Console.WriteLine("Число является паллиндромом");
else 
Console.WriteLine("Число не является паллиндромом");