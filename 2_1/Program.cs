// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int TakeNum(int num)
{
    Console.WriteLine("" + num);
    return num / 10 % 10;
        }
    Console.WriteLine("Введите любое трехзначное число");
    int num2 = int.Parse(Console.ReadLine());
    int result = TakeNum(num2);
    Console.WriteLine(result);