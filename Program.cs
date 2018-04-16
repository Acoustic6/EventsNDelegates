using System;
using System.Collections.Generic;

namespace EventsNDelegates
{
    class TrainSignalEventArgs
    {
        public string trainType;
    }

    class TrainSignal
    {
        public string type;

        public event EventHandler<TrainSignalEventArgs> ProduceASignal;
        
        public void HereComesATrain()
        {
            ProduceASignal(this, new TrainSignalEventArgs { trainType = "Express" } );
        }
    }

    class Car
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.ProduceASignal += Stop;
        }
        private void Stop(object sender, TrainSignalEventArgs eventArgs)
        {
            if (sender is TrainSignal)
                Console.WriteLine($"I hear a {((TrainSignal)sender).type} signal!");
            Console.WriteLine($"Stopping! {eventArgs.trainType} is coming!");
                
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var trainSignal = new TrainSignal { type = "loud" };
            var car = new Car(trainSignal);
            trainSignal.HereComesATrain();
        }
    }
}
