using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code example - Farid Naisan
//TODO:  COMMENT THE CODE!
namespace CandiesMachineMonitorCS
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Title = "Producer/Consumer Using Monitors";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.Clear ( );

            Controller obj = new Controller ( );

            Console.WriteLine ( "Press a button to quit!" );
            Console.ReadLine ( );  //Let console window stay on the screen

        }
    }
}
