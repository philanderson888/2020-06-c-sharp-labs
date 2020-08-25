using System;

namespace lab_30_basic_event
{
    class Program
    {
        delegate void MyDelegate();

        static event MyDelegate MyEvent;

        static void Main(string[] args)
        {
            // Events ==> link to MULTIPLE METHODS
            // Event ==> external to program 
            // User events - onclick, onkeydown/up/press, double click, mouse over, mouse out
            // Data events - onload, onpageload, ondata arrive, track % complete (map to progress bar), on data complete
            //             - notification of email / chat message

            // 1. create delegate (specify methods which can run)
            // 2. create 'null' event 
            // 3. add/remove methods using +=  or -=.  Order matters => methods fire in this order
            MyEvent += Method01;
            MyEvent += Method02;
            MyEvent += Method03;

            // call event
            MyEvent();
        }


        static void Method01()
        {
            Console.WriteLine("running method 01");
        }


        static void Method02()
        {
            Console.WriteLine("running method 02");
        }


        static void Method03()
        {
            Console.WriteLine("running method 03");
        }

    }
}
