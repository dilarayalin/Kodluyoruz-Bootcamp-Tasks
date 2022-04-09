using System;
using System.Collections.Generic;
using System.Linq;

namespace CityList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string> {"İstanbul" , "İzmir", "Ankara" , "Niğde", "İstanbul", "Ankara", "İstanbul", "Muğla", "Muğla"};

            List<string> cityList = cities.Distinct().ToList();

            foreach (var item in cityList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
