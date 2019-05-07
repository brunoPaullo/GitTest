using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = $"Your Amount is {GetImport(8)}";
            GetMessage(message);
            GetMessage(GetEmail());
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
      
        private static string GetEmail()
        {
            return "example@gamil.com";
        }
    }
}
