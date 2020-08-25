using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;
using Newtonsoft.Json;

namespace lab_37_http_deserialize_to_json
{
    class Program
    {
        static List<ToDo> todos = new List<ToDo>();
        static List<ToDo> todosAsync = new List<ToDo>();
        static Stopwatch s = new Stopwatch();

        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos");

        static void Main(string[] args)
        {

            GetTodos();
            Console.WriteLine($"Synchronously we have obtained {todos.Count} records");
            todos.ForEach(item => Console.WriteLine($"ID : {item.id,-10} User: {item.userId,-15}" +
                $"Title: {item.title}"));



            s.Start();
            GetTodosAsync();
            Console.WriteLine($"Immediately async data length is {todosAsync.Count}");
            Console.WriteLine($"Program terminates at time {s.ElapsedMilliseconds}");

            Thread.Sleep(120);
            Console.WriteLine($"After a pause, async data has now arrived. Length is {todosAsync.Count}");
        }

        // sync
        static void GetTodos()
        {
            using (var httpclient = new HttpClient())
            {
                // string with 200 items
                var data = httpclient.GetStringAsync(url);
                // deserialize
                todos = JsonConvert.DeserializeObject<List<ToDo>>(data.Result);
            }
        }

        // async 
        static async void GetTodosAsync()
        {
            using (var httpclient = new HttpClient())
            {
                var data = await httpclient.GetStringAsync(url);
                todosAsync = JsonConvert.DeserializeObject<List<ToDo>>(data);
                Console.WriteLine($"Todos Async Data Has Arrived at {s.ElapsedMilliseconds}");
            }
        }
    }

    class ToDo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string completed { get; set; }
    }
}
