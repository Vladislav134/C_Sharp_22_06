// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string a = Console.ReadLine()!;
switch (a)
{
case "1":
Console.Write("Понедельник, будний");
break;
case "2":
Console.Write("Вторник, будний");
break;
case "3":
Console.Write("Среда, будний");
break;
case "4":
Console.Write("Четверг, будний");
break;
case "5":
Console.Write("Пятница, будний");
break;
case "6":
Console.Write("Суббота, выходной");
break;
case "7":
Console.Write("Воскресенье, выходной");
break;
default:
Console.Write("Такого дня недели нет");
break;
}
