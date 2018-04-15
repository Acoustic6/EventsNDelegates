using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = GetAllNumbersSurvivedCondition(new[] { 2, 7, 6, 9, 4, 6, 2 }, i => i < 5);
            
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

            Action a;
        }

        static IEnumerable<T> GetAllNumbersSurvivedCondition<T>(IEnumerable<T> inputArray, Func<T, bool> condition)
        {
            foreach(T item in inputArray)
            {
                if (condition(item))
                    yield return item;
            }
        }
    }
}
