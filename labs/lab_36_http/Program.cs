using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lab_36_http
{
    class Program
    {
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos/1");
        static Uri url2 = new Uri("https://www.bbc.co.uk");

        static void Main(string[] args)
        {
            /*
            HTTP and WEB
            
            Http Hypertext Transfer Protocol

            Web Page is PLAIN TEXT FILE just called .html .htm

            <HTML>
                <h1></h1>
                <p></p>
            </HTML>

            Browser INTERPRET and RENDER HTML file

            HTML  way data laid out on page so browser can interpret it correctly and show you the page

            HTML            STRUCTURE, LAYOUT                       (( SKELETON     ))
            CSS             COLOUR, SPACING, DIFFERENT SCREEN SIZE  (( VISIBLE PART ))
            JAVASCRIPT      ACTIVE PART                             (( MOTION       ))

            HTML = PAGE IE DATA
            
            HTTP = MECHANISM TO SEND DATA ACROSS WEB FROM WEB SERVER TO WEB CLIENT (BROWSER)

            IPV4   1.2.3.4   WHERE EACH NUMBER 0<N<255    192.168.X.Y  PRIVATE   
            IPV6   FE80:1234::0000:CCDE
            URL    www.facebook.com
            DNS    DOMAIN NAME SERVER/SERVICE   TELEPHONE BOOK FOR INTERNET     NAME  facebook.com    NUMBER  1.2.3.4

            PUBLIC IP EXAMPLE???
                1) YOU!!!           WHAT IS MY IP !!
                2) FACEBOOK         a)   ping, tracert           b) nslookup

            API 'method' : GET   POST   PUT   DELETE        CRUD       GET=READ  POST=CREATE  PUT=UPDATE  

            API Application Programming Interface

                ==> does the word API relate just to the internet???   NO  
                An API is           USER            AGREED METHOD OF COMMUNICATION         COMPLEX COMPUTER OPERATIONS HERE
             

            REST API IS WEB API   GET POST PUT DELETE

            PORT   channel for data to flow into your computer  (2^16 of them = 65536)

            URL    https://....              uniform resource location
            URI    similar to URL                             indentifier

            ABSOLUTE PATH   c:\folder\file
            RELATIVE PATH   relative to .exe location  (easier to use)

            HOST         MACHINE, DEVICE
            HOSTNAME     ENGLISH NAME OF YOUR DEVICE 
            LOCALHOST    NAME OF MY PC     https://localhost:8080


            PORT 
                80 HTTP   443 HTTPS      22 SSH      25 SMTP       53 DNS          110 POP 

            PROXY       client          PROXY HERE                router           server
             


            C# HAS 3 WAYS OF OBTAINING INTERNET DATA

            1) WEBCLIENT

                super simple  (wrapper over WEBREQUEST)

            2) WEBREQUEST

                full detail

            3) HTTPCLIENT

                use this one!!!  
             
             */

            // synchronous programming
            GetDataUsingWebClient();
            // GetPageUsingWebClient();
            GetPageUsingWebRequest();

            GetDataUsingHttpClient();
        }


        static void GetDataUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            var data = webclient.DownloadString(url);
            Console.WriteLine(data);
        }

        static void GetPageUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFile(url2, "bbcWebPage.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bbcWebPage.html");
        }

        static void GetPageUsingWebRequest()
        {
            var bbcPageRequest = WebRequest.Create(url2);
            bbcPageRequest.Proxy = null;

            var bbcPageResponse = bbcPageRequest.GetResponse();

            // interrogate response
            Console.WriteLine("\n\nBBC Page has arrived\n");
            Console.WriteLine(bbcPageResponse.ContentType);
            Console.WriteLine(bbcPageResponse.ContentLength);

            // interrogate request - page headers
            Console.WriteLine("\n\nGetting Page Header Information");

            foreach(var item in bbcPageResponse.Headers)
            {
                Console.WriteLine(item.ToString());
            }


            // string array of keys
            var pageResponseHeaders = bbcPageResponse.Headers.AllKeys;
            // values
            foreach (var key in pageResponseHeaders)
            {
                Console.WriteLine(key);

                foreach (var value in bbcPageResponse.Headers.GetValues(key))
                {
                    Console.WriteLine($"\t\t : {value}");
                }
            }


        }

        static void GetDataUsingHttpClient()
        {
            var httpClient = new HttpClient();
            // sync at present
            var httpResponse = httpClient.GetStringAsync(url);
            var data = httpResponse.Result;
            Console.WriteLine("\n\nGetting Data using HttpClient\n");
            Console.WriteLine(data);

            // turn from string into JSON object
            // add Newtonsoft.json library
            Console.WriteLine("\n\nGetting Data using Newtonsoft.json");
            var json = JObject.Parse(data);
            Console.WriteLine(json["userId"]);
            Console.WriteLine(json["id"]);
            Console.WriteLine(json["title"]);
            Console.WriteLine(json["completed"]);

            // deserialize JSON into proper real OOP data
            Console.WriteLine("Deserializing JSON to OOP instance");
            var user = JsonConvert.DeserializeObject<User>(data);
            Console.WriteLine($"\n\nOOP data deserialized is");
            Console.WriteLine($"{user.userId,-20}{user.id,-10}{user.title,-20}{user.completed}");
        }

        // take this to the next level - deserialize a LIST OF USERS!

    }


    class User
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string completed { get; set; }
    }

}
