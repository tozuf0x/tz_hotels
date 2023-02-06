using System;
using System.Linq;

namespace ArrayIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 7, 17, 1, 9, 1, 17, 56, 56, 23 };
            int[] secondArray = new int[] { 56, 17, 17, 1, 23, 34, 23, 1, 8, 1 };

            int[] intersection = GetIntersection(firstArray, secondArray);
            Console.WriteLine("Intersection: " + string.Join(", ", intersection));
        }

        static int[] GetIntersection(int[] firstArray, int[] secondArray)
        {
            return firstArray.Intersect(secondArray).ToArray();
        }
    }
}
