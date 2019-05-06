using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = $"Your Amount is {GetImport(8)}";
            GetMessage(message);
            Console.ReadKey();
        }

        private static void GetMessage( string message)
        {
            Console.WriteLine(message);
        }

        private static int GetImport(int amount)
        {
            return amount * 10;
        }
    }
}
