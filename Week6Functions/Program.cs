using System;
using System.Collections.Concurrent;
using System.Dynamic;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //call a function
            HelloUser();
            Sum();
        }

        public static void HelloUser() //create a function
        {
            Console.WriteLine("Enter your name");
            string UserName = Console.ReadLine();
            Console.WriteLine($"Hello, {UserName}");
        }

        public static void Sum()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int o = Int32.Parse(Console.ReadLine());

            int result = a + o;
            Console.WriteLine(result);
        }
    }
}
