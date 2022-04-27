using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//Code example - Farid Naisan
//TODO:  COMMENT THE CODE!
namespace CandiesMachineMonitorCS
{
    class Controller
    {
        private CandyMachine candies;
        private Thread prodThread;
        private Thread consThread;

        public Controller()
        {
            Random random = new Random();
            candies = new CandyMachine(10,12);

            Producer producer = new Producer(candies, random);
            prodThread = new Thread(new ThreadStart(producer.run));
            prodThread.Name = "Producer";
   
            Consumer consumer = new Consumer(candies, random);
            consThread = new Thread(new ThreadStart(consumer.run));
            consThread.Name = "Consumer";

            prodThread.Start();
            consThread.Start();
            prodThread.Join();
            consThread.Join();

            //Start(); for testing if threads are alive
        }
       
        private void Start()
        { 
            bool done = false;

            //comment out while and check what happens!
            while (!done)
            {
                if (prodThread.IsAlive || consThread.IsAlive)
                    Thread.Sleep ( 1000 );
                else
                {
                    done = true;
                    Console.WriteLine ( "Threads are dead now!" );
                }
            }

            Console.WriteLine ( "Main thread closes the application now!" );

        }
    }
}
