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
    class Consumer
    {
        private CandyMachine sharedRes;
        private Random random;

        public Consumer (CandyMachine sharedRes, Random random)
        {
            this.sharedRes = sharedRes;
            this.random = random;
        }
        public void run ( )
        {
   
            while (!sharedRes.IsDone)
            {
                Candy candy = null;

                candy = sharedRes.Consume ( );

                Thread.Sleep ( random.Next ( 600 ) );
            }
        }
    }
}
