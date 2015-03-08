using Microsoft.Owin.Hosting;
using System;

namespace OwinConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args) {
            const string baseUrl = "http://localhost:5001/";

            using (WebApp.Start<Startup>("http://localhost:5001")) {
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();
            }
        }
    }
}
