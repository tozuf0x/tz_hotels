using System;

namespace CityArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Moscow", "Saint Petersburg", "Voronezh" };
            Console.WriteLine(CitiesToString(cities));
        }

        static string CitiesToString(string[] cities)
        {
            return string.Join(", ", cities) + ".";
        }
    }
}
