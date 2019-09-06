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
            LaserControlBoard lcb = new LaserControlBoard();
            lcb.OpenCommunication(9);
            LaserControlGlobalState laserControlGlobalState = lcb.GetGlobalState();
            lcb.SetInterlock(true);
            Console.WriteLine(laserControlGlobalState.Interlock);
        }
    }
}
