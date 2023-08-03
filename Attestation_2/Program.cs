// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Sum(int n, int m)
{
    
    if (n <= 0 && m <= 0)
    Console.WriteLine("числа не натуральные");
    if (n < m)
    return 0;
     return Sum(n - 1, m) + n;
    } 
    Console.Write($" {Sum(8 , 3)} ");