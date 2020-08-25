using System;

namespace lab_28_delegates
{
    class Program
    {

        delegate void Delegate01();

        delegate string Delegate02(int x, bool y);

        static void Main(string[] args)
        {
            // shorter version
            // notice : no brackets in method ==> just placeholder, don't call right now
            Delegate01 mydelegateinstance = Method01;

            Action myotherdelegateinstance = Method02;

            // declare
            Delegate02 delegateinstance = Method03;

            // run 
            mydelegateinstance();
            myotherdelegateinstance();

            // run
            Console.WriteLine(delegateinstance(15, true));
            Console.WriteLine(delegateinstance(23, false));

        }

        static void Method01()
        {
            Console.WriteLine("Running Method 01");
        }

        static void Method02()
        {
            Console.WriteLine("Running Method 02");
        }

        static string Method03(int x, bool gender)
        {
            var genderstring = gender ? "male" : "female";

            return $"Your age is {x} and your gender is {genderstring}";
        }
    }
}
