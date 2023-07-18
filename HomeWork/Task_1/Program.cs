using System;

namespace Conditional
{
    class IfElseStatement
    {
        public static void Main(string[] args)
        {
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} меньше 5", number);
            }
            else
            {
                Console.WriteLine("{0} больше или равно 5", number);
            }

            Console.WriteLine("Эта строка выполняется всегда.");
        }
    }
}