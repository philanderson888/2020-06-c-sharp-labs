using System;

namespace lab_13_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var number01 = 0b_1010;
            var number02 = 0b_10100;  // multiply by 2
            var number03 = 0b_101;   // divide by 2
            var bigNumber = 123_456_789;

            Console.WriteLine(number01);
            Console.WriteLine(number02);
            Console.WriteLine(number03);

            var number04 = 0b_101000;
            Console.WriteLine(number04);
            Console.WriteLine(number04 >> 1);
            Console.WriteLine(number04 << 1);
            Console.WriteLine(number04 >> 2);
            Console.WriteLine(number04 >> 3);
            Console.WriteLine(number04 >> 4);
            Console.WriteLine(number04 >> 5);
            Console.WriteLine(number04 >> 6);



        }
    }
}
