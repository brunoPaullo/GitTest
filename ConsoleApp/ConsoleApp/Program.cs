﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            GetMessage(message);
            GetMessage(GetEmail());
            Console.ReadKey();
        }

        private static void GetMessage( string message)
        {
            Console.WriteLine(message);
        }

        private static string GetEmails()
        {
            return "example@gamil.com";
        }
    }
}
