using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Object_Taxi
{
    public class Taxi
    {
        //propertis
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty == true)
                Console.WriteLine("On Duty: Yes");
            else
                Console.WriteLine("On Duty: No");
            Console.WriteLine("Jumlah Penumpang : {0}", NumPassenger);
        }
            public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang\n", DriverName);
        }
        public void DropOffPassengers()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang\n", DriverName);
        }

    }
}
