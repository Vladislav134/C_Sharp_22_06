int a, b;
Console.WriteLine(«Введите два числа: »);
a = int.parse(console.readline()!);
b = int.parse(console.readline()!);
 if (a<b)
 {
    Console.WriteLine("{0} наибольшее число", b);
 }
 else 
 {
    Console.WriteLine("{0} наибольшее число", a);
 }
 Console.ReadLine();