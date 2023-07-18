// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
Console.WriteLine( "Введите три числа: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int Maks;
if (a < b )
 {
    Maks = b;
     }
if (b < c)
 {
    Maks = c;
 }
    else Maks = a; 
    Console.WriteLine("{0} наибольшее число", Maks);
   Console.ReadLine();