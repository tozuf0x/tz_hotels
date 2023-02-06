using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(IsPrime(6));
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
