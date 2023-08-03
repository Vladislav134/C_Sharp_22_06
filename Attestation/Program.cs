// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
void PrintNumber(int n, int m)
{
    if (n % 2 == 1)
    n = n - 1;
    if (n < m)
    return;
  PrintNumber(n-1, m);
Console.Write($" {n} ");
}
PrintNumber(11, 3);