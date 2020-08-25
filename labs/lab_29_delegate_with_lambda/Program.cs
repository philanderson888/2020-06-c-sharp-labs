using System;

namespace lab_29_delegate_with_lambda
{
    class Program
    {

        delegate string MyDelegate(string name, int y);

        static void Main(string[] args)
        {
            MyDelegate instance = MyMethod;
            Console.WriteLine(instance("fred", 12));

            // use anonymous method instead with lambda
            MyDelegate instance2 = (name, y) =>
            {
                return $"Thanks, {name} you have entered number {y} ";
            };

            Console.WriteLine(instance2("bob", 33));
            
        }

        static string MyMethod(string name, int y)
        {
            return $"Thanks, {name} you have entered number {y} ";
        }
    }
}
