// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int TakeNum(int num)
{       
if (num < 100)
     {
Console.WriteLine("третьей цифры нет");
         }
         
         if (num >= 100)
     {
while (num >= 1000)
{
        num = num / 10;
                    }
        num = num % 10;
         }  
         return num; 
        }

    Console.WriteLine("Введите любое число");
    int num3 = int.Parse(Console.ReadLine()!);
    int result = TakeNum(num3);
    Console.WriteLine(result);