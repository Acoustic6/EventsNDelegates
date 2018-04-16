using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class TrainSignal
    {
        public Action ProduceASignal;
        public void HereComesATrain()
        {
            ProduceASignal();
        }
    }

    class Car
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.ProduceASignal += Stop;
        }
        private void Stop()
        {
            Console.WriteLine("Stopping!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrainSignal trainSignal = new TrainSignal();
            Car car1 = new Car(trainSignal);
            Car car2 = new Car(trainSignal);
            Car car3 = new Car(trainSignal);
            //trainSignal.HereComesATrain();

            trainSignal.ProduceASignal();//direct call.
            trainSignal.ProduceASignal = null;//nullifying!
        }
    }
}
