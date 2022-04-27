using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//Code example - Farid Naisan
//TODO:  COMMENT THE CODE!

namespace CandiesMachineMonitorCS
{
    /// <summary>
    /// Produces a candy (refills the machine with candy items)
    /// </summary>
    class Producer
    {
        private CandyMachine sharedRes;
        private Random random;

        public Producer (CandyMachine sharedRes, Random random)
        {
            this.sharedRes = sharedRes;
            this.random = random;
        }

        static int num = 101; //just to generate a name for an item using this number

        public void run ( )
        {
            Candy candy = null;

            while (!sharedRes.IsDone)
            {
                //ME (for n++) not needed as we have only one thread
                candy = new Candy ( num++ ); 
                sharedRes.Produce ( candy );
                Thread.Sleep(random.Next(600));
            }

        }
    }
}
