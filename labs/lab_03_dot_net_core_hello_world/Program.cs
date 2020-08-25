using System;
using System.Diagnostics;

namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            #region maincodeblock

            Console.WriteLine("Hello World From A Programmer");
            int[] myArray = {1,2,3,4,5};
            foreach(var item in myArray){
                System.Console.WriteLine(item);
            }

            #region subloop

            Console.WriteLine();
            int total = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                total += i;
            }

            #endregion

            #endregion maincodeblock



            // compile if the BUILD IS DEBUG BUILD
#if DEBUG
            Console.WriteLine("This is code only compiled in debug mode");
#endif

#if RUNNINGTEST01
            Console.WriteLine("Running Test01");
#endif


            // Debugging

            // Loggging

            // Console 

            Console.WriteLine("output to console");
            Debug.WriteLine("outputting debug output");
            Trace.WriteLine("outputting trace output");


            Console.ReadLine();




        }
    }
}
