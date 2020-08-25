using System;

namespace lab_27_delegates
{
    class Program
    {

        delegate void MyDelegate01();

        static void Main(string[] args)
        {
            // Delegates

            // 1. Placeholder for one or more methods
            // 2. Can use in anonymous 'lambda' expresssions, very useful particularly with 'async' web calls
            // 3. Link to events ==> EVENT FIRES EG BUTTON CLICK ==> All methods must match pattern given in our delegate
            //                           void MyDeleagate01();   Any methods match pattern  void MyMethod();
            //                           string            (int)                            string       (int)


            // create event ==> run given methods
            // 1. Create delegate (top)

            // 2. Create delegate instance
            var delegateInstance = new MyDelegate01(Method02);

            // 3. run delegate instance ==> call our method
            delegateInstance();

        }

        // These are Action methods
        static void Method01()
        {
            Console.WriteLine("I am Method01");
        }
        static void Method02()
        {
            Console.WriteLine("I am Method02");
        }


    }
}
