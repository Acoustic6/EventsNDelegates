using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class Program
    {

        class CompilersClass
        {
            public int i;
            public int TheMethodGeneratedFromLambdaExpression()
            {
                return i++;
            }
        }

        static void Main(string[] args)
        {
            Func<int> action = new CompilersClass().TheMethodGeneratedFromLambdaExpression;
            action();
            action();
            action();
        }

        static Action GetAnAction()
        {
            int i = 0;
            return () => i++;
        }
    }
}
