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
                LaserControlBoard lcb = new LaserControlBoard();
                if (lcb.OpenCommunication(3))
                {
                    lcb.SetInterlock(true);

                    LaserControlGlobalState laserControlGlobalState = lcb.GetGlobalState();
                    Console.WriteLine("Interlock: " + laserControlGlobalState.Interlock.ToString());
                }
            }
            catch(OEILaserControlBoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
