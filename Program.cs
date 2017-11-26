using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = GetAllNumbersLessThanFive(new[] { 2, 7, 6, 9, 4, 6, 2 });
            
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }

        static IEnumerable<int> GetAllNumbersLessThanFive(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 5)
                    yield return number;
            }
        }

        static IEnumerable<int> GetAllNumbersLessThanTen(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 10)
                    yield return number;
            }
        }

        static IEnumerable<int> GetAllNumbersGreaterThanEight(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number > 8)
                    yield return number;
            }
        }
    }
}
