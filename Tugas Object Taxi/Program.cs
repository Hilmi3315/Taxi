using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Object_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();


            taxi.DriverName = "HilmiPutroUtomo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 3;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassengers();

            Console.ReadKey();

        }
    }
}
