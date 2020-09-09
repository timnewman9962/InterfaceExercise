using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public int NumWheels { get; set; }
        public int EngineCylinders { get; set; }
        public int NumSeats { get; set; }
        public int Year { get; set; }
        public string MakeDescription();
    }
}
