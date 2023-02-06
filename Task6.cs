using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            PrintMultiplicationTable(n);
        }

        static void PrintMultiplicationTable(int n)
        {
            Console.Write("    ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            Console.WriteLine("    " + new string('-', 4 * n));

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,2} |", i);
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
