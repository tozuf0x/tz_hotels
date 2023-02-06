using System;

namespace RoundToMultipleOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            float input = 27.8f;
            float output = RoundToMultipleOfFive(input);
            Console.WriteLine(output);
        }

        static float RoundToMultipleOfFive(float num)
        {
            float rounded = (float)Math.Round(num / 5) * 5;
            return rounded;
        }
    }
}
