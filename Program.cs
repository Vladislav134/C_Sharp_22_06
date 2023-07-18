// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine( "Введите два числа: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
 if ( a < b )
 {
    Console.WriteLine("{0} наибольшее число", b);
 }
 else 
 {
    Console.WriteLine("{0} наибольшее число", a);
 }
 Console.ReadLine();