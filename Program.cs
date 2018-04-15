using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = GetAnAction();
            //i is 0
            action();
            //i is 1
            action();
            //i is 2
            action();
            //i is 3
        }

        static Action GetAnAction()
        {
            int i = 0;
            return () => i++;
        }
    }
}
