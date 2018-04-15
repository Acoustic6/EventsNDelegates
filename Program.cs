using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    delegate bool MeDelegate(int number); 

    class Program
    {
        static bool NumberLessThanFive(int number) { return number < 5; }
        static bool NumberLessThanTen(int number) { return number < 10; }
        static bool NumberGreaterThanEight(int number) { return number > 8; }

        static void Main(string[] args)
        {
            IEnumerable<int> result = GetAllNumbersSurvivedCondition(new[] { 2, 7, 6, 9, 4, 6, 2 }, NumberLessThanFive);
            
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }

        static IEnumerable<int> GetAllNumbersSurvivedCondition(IEnumerable<int> inputArray, MeDelegate condition)
        {
            foreach(var item in inputArray)
            {
                if (condition(item))
                    yield return item;
            }
        }
    }
}
