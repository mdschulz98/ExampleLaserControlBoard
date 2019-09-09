using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OEI.LaserControlBoard;

namespace ExampleLaserControlBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //LaserControlBoard lcb = new LaserControlBoard();
                //if (lcb.OpenCommunication(3))
                //{
                //    lcb.SetInterlock(true);

                //    LaserControlGlobalState laserControlGlobalState = lcb.GetGlobalState();
                //    Console.WriteLine("Interlock: " + laserControlGlobalState.Interlock.ToString());
                //}
                LaserControlGlobalState lcgs = new LaserControlGlobalState("14|0|255|255|0|0|1|0|0|1|2|3084.1}");
                Console.WriteLine(lcgs.ToString());
                LaserControlStageState lcss = new LaserControlStageState("17|0|1|0|1|1356|2035}\r");
                Console.WriteLine(lcss.ToString());
            }
            catch(OEILaserControlBoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
