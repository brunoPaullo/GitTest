using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            GetMessage(message);
            Console.ReadKey();
        }

        private static void GetMessage( string message)
        {
            Console.WriteLine(message);
        }
    }
}
