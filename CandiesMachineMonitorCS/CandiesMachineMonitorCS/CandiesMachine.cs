using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Code example - Farid Naisan
//TODO:  COMMENT THE CODE!

namespace CandiesMachineMonitorCS
{
    /// <summary>
    /// This my buffer class, a contianer for shared data,
    /// methods and synchronizations
    /// </summary>
    class CandyMachine
    {
        private List<Candy> candies;  //buffer - shared resource
        private int bufferSize;
        private int maxItems;
        private static int itemsConsumed = 0;
        private Object lockObj = new Object ( );

        public CandyMachine (int maxBufferSize, int max)
        {
            candies = new List<Candy> ( );
            bufferSize = maxBufferSize;
            maxItems = max;
        }
        public void Produce (Candy candy)
        {
            

            lock (lockObj)  //same as Monitor.Enter 
            {
                while (IsFull)
                {
                    Monitor.Wait ( lockObj );
                }

                candies.Add ( candy );
                Console.WriteLine("Item " + candy.Name + " produced!");
  
                Monitor.Pulse ( lockObj ); //lock is NOT released here

            } //same as Monitor.Exit, lock is relaeased here
        }
        object obj = new object();
        public Candy Consume ( )
        {
            Candy candy = null;

            //lock (lockObj)      //same as Monitor.Enter	//Enter monitor
                Monitor.Enter(lockObj);
                 
                while (IsEmpty)
                {
                    Monitor.Wait ( lockObj );
                }
                candy = candies[0];  //Take out the first one
                Console.WriteLine("Item " + candy.Name + " consumed!");
  
                candies.RemoveAt ( 0 );

                itemsConsumed++;
                Monitor.Pulse ( lockObj);  //awakened threads will have to wait until lock is released 
                Monitor.Exit(lockObj);  //lock is relaeased here
             
           
            return candy;

        }

        public bool IsEmpty
        {
            get { return candies.Count == 0; }
        }

        public bool IsFull
        {
            get { return candies.Count >= bufferSize; }
        }

        public bool IsDone
        {
            get { return itemsConsumed >= maxItems; } //stop after 100 items produced and consumed
        }

    }
}
