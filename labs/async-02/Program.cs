using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace async_02
{
    class Program
    {
        static List<string> fileRows = new List<string>();
        static string[] array;
        static Stopwatch s = new Stopwatch();

        static void Main(string[] args)
        {

            if (!File.Exists("log.dat"))
            {
                File.Delete("log.dat");
                Console.WriteLine("\n\nBuilding text file\n\n");
                for (int i = 0; i < 100000; i++)
                {
                    File.AppendAllText("log.dat", $"New log entry {i} at {DateTime.Now}\n");
                }
                Console.WriteLine("File built . . . \n\n");
            }
            s.Start();
            ReadDataAsync();  // async
            var array = ReadDataAsync2();   // async
            Console.WriteLine("Program has completed");

            array.Wait();
            Console.WriteLine($"\n\nReadDataAsync2() data arrived at {s.ElapsedMilliseconds}");
            //PrintData(array.Result);


        }

        static async void ReadDataAsync()
        {
            array = await File.ReadAllLinesAsync("log.dat");
            Console.WriteLine($"\n\nReadData data arrived at {s.ElapsedMilliseconds}");
            //PrintData(array);
        }



        static async Task<string[]> ReadDataAsync2()
        {
            var array = await File.ReadAllLinesAsync("log.dat");
            Console.WriteLine($"\n\nReadData2 data arrived at {s.ElapsedMilliseconds}");
            return array;
        }

        static void PrintData(string[] data)
        {
            var counter = 0;
            foreach (var item in data)
            {
                Console.WriteLine(item);
                counter++;
                if (counter > 50) break;
            }
        }

    }
}
