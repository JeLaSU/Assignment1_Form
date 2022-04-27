using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code example - Farid Naisan
    //TODO:  COMMENT THE CODE!
namespace CandiesMachineMonitorCS
{   
    class Candy
    {
        private String name;
        private double price;
        private double weight; //gram

        public Candy (int num)
        {
            name = "Number" + num.ToString ( );
        }

        public String Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty ( value ))
                    name = value;
            }
        }

    }
}
