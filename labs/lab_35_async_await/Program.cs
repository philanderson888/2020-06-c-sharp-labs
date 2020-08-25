using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_35_async_await
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static List<string> fileOutput2 = new List<string>();
        static List<string> streamReaderAsyncOutput = new List<string>();

        static void Main(string[] args)
        {
            //  SYNC CODE  ... LINE BY LINE

            // ASYNC CODE


            // keyword                  Convention
            /* async      Task<string[]>    DoThisAsync       (){   
                    var output = await ReadFileAsync("thisfile.txt")
                    var output = await GetHttp/JsonDataAsync(URL)
                    return output;
               }

            */



            // Walkthrough : read file sync and async

            // 1. Create text file 10,000 lines?  
            // 2. method to read text file to array  a) File.Read..    b) StreamReader (bonus)
            // 3. call this method from Main()
            // 4. time application start to finish


            s.Start();
            
            //File.Delete("data.txt");

            if (!File.Exists("data.txt"))
            {
                for (int i = 0; i< 10000; i++)
                {
                    File.AppendAllText("data.txt",$"Adding a new line to text file at {DateTime.Now}\n");
                }

                Console.WriteLine($"File create took {s.ElapsedMilliseconds}");
            }




            // synchronous read
            s.Restart(); 
            var array01 = ReadTextFileToArray();
            Console.WriteLine($"Synchronous read took {s.ElapsedMilliseconds}");



            // streamreader read to list
            s.Restart();
            List<string> fileOutput = new List<string>();
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    fileOutput.Add(reader.ReadLine());
                }
            }
            Console.WriteLine($"Streamreader to list took {s.ElapsedMilliseconds}");



            // streamreader read to stringbuilder
            s.Restart();
            var stringbuilder = new StringBuilder();
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    stringbuilder.AppendLine(reader.ReadLine());
                }
            }
            string fileOutput2 = stringbuilder.ToString();
            Console.WriteLine($"Streamreader to string took {s.ElapsedMilliseconds}");


            // async read - basic FileReadAsync
            s.Restart();
            ReadTextFileToArrayAsync();
            Console.WriteLine($"Async File Read took {s.ElapsedMilliseconds} with string of length {fileOutput2.Length} records");



            // async read - streamreader
            s.Restart();
            StreamReadTextFileAsync();
            Console.WriteLine($"Async Stream Read Read took {s.ElapsedMilliseconds} with {streamReaderAsyncOutput.Count} records");


            Thread.Sleep(3000);
            Console.WriteLine($"Async File Read has string of length {fileOutput2.Length} ");
            Console.WriteLine($"Async Stream Read has {streamReaderAsyncOutput.Count} records");


            // final lab - get result but can you turn this into proper async overnight?
            // (this way only partly works - task overnight to improve it)
            s.Restart();
            // this returns a 'task'
            var arrayOutput = ReturnTextFileToArrayAsync();
            Console.WriteLine($"Async array returned in {s.ElapsedMilliseconds} with {arrayOutput.Result.Length} records");



        }



        static string[] ReadTextFileToArray()
        {
            var array = File.ReadAllLines("data.txt");
            return array;
        }


        static async void ReadTextFileToArrayAsync()
        {
            var array = await File.ReadAllLinesAsync("data.txt");
            fileOutput2 = array.ToList();
        }

        // this one returns data with Task<T> structure
        static async Task<string[]> ReturnTextFileToArrayAsync()
        {
            var array = await File.ReadAllLinesAsync("data.txt");
            return array;
        }



        static async void StreamReadTextFileAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    streamReaderAsyncOutput.Add(await reader.ReadLineAsync());
                }
            }
        }


    }
}
