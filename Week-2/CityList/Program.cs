using System;
using System.Collections.Generic;
using System.Linq;

namespace CityList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Singular display of repeating records in a list
             */

            List<string> cities = new List<string> {"İstanbul" , "İzmir", "Ankara" , "Niğde", "İstanbul", "Ankara", "İstanbul", "Muğla", "Muğla"};

            List<string> cityList = cities.Distinct().ToList(); //We removes duplicate cities from list with Distinct method.

            foreach (var item in cityList) //We write non-duplicate elements on the screen.
            {
                Console.WriteLine(item);
            }
        }
    }
}
