using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace lab_34_task_parallel_processing
{
    class Program
    {
        delegate void MyDelegate();

        static void Main(string[] args)
        {
            // C# has a library to help with task 'parallel' processing

            // Firstly ==> running methods in parallel with Parallel.Invoke

            Action instance01 = OvernightTask01;
            Action instance02 = OvernightTask02;
            Action instance03 = OvernightTask03;
            Action instance04 = OvernightTask04;
            Action instance05 = OvernightTask05;

            Parallel.Invoke(
                () => { OvernightTask01(); },
                () => { OvernightTask02(); },
                () => { OvernightTask03(); },
                () => { OvernightTask04(); },
                () => { OvernightTask05(); },
                instance01,
                instance02,
                instance03,
                instance04,
                instance05
            );


            var s = new Stopwatch();
            s.Start();

            // parallel for
            var taskArray = new Task[32];
            for(int i = 0; i < taskArray.Length; i++)
            {
                var j = i;

                taskArray[j] = Task.Run(
                    () => {
                        Thread.Sleep(5);
                        Console.WriteLine($"Task {j} has completed at {s.ElapsedMilliseconds}");  
                    }
                );
            }

            // parallel for
            Parallel.For(0,10, 
                i => {
                    Thread.Sleep(7);
                    Console.WriteLine($"Parallel For Job {i} - running background processing");
                }
            );


            
            
            // parallel foreach
            var stringArray = new string[] { "hey", "there", "i", "am", "string", "array" };

            Parallel.ForEach(stringArray,
                (item) => { Console.WriteLine($"Processing string array item {item} with a length of {item.Length}");  }
            );



            // parallel LINQ from database
            var customers = new List<string>(); // imagine list from Northwind
            // LINQ as parallel
            var processingOutput = customers.AsParallel();


            Console.WriteLine($"all completed at {s.ElapsedMilliseconds}");

            Console.ReadLine();




        }

        static void OvernightTask01() { Console.WriteLine("Processing overnight task 01"); }
        static void OvernightTask02() { Console.WriteLine("Processing overnight task 02"); }
        static void OvernightTask03() {
            Thread.Sleep(500);
            Console.WriteLine("Processing overnight task 03"); 
        }
        static void OvernightTask04() { Console.WriteLine("Processing overnight task 04"); }
        static void OvernightTask05() { Console.WriteLine("Processing overnight task 05"); }
    }
}
