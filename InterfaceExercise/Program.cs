using System;

namespace InterfaceExercise
{
    class Program
    {
        
        class Car : IVehicle, ICompany
        {
            public int TrunkSize { get; set; }
            public string CarProperty { get; set; }
            public int NumWheels { get; set; }
            public int EngineCylinders { get; set; }
            public int NumSeats { get; set; }
            public int Year { get; set; }
            public string Logo { get; set; }
            public string Headquarters { get; set; }

            public string MakeDescription()
            {
                string description = $"This Car has a trunk size of {TrunkSize} cu.ft. and a property of {CarProperty}.\n";
                description += $"The vehicle was manufactured in {Year} with a {EngineCylinders}-cylinder engine, {NumSeats} seats, and {NumWheels} wheels\n";
                description += $"The manufacturer has headquarters in {Headquarters} and uses the logo \"{Logo}\".\n";

                return description;

            }
        }

        class Truck : IVehicle, ICompany
        {
            public int BedSize { get; set; }
            public string TruckProperty { get; set; }
            public int NumWheels { get; set; }
            public int EngineCylinders { get; set; }
            public int NumSeats { get; set; }
            public int Year { get; set; }
            public string Logo { get; set; }
            public string Headquarters { get; set; }
            public string MakeDescription()
            {
                string description = $"This Truck has a bed size of {BedSize} cu.ft. and a property of {TruckProperty}.\n";
                description += $"The vehicle was manufactured in {Year} with a {EngineCylinders}-cylinder engine, {NumSeats} seats, and {NumWheels} wheels\n";
                description += $"The manufacturer has headquarters in {Headquarters} and uses the logo \"{Logo}\".\n";

                return description;

            }
        }

        class Suv : IVehicle, ICompany
        {
            public int CargoSize { get; set; }
            public string SuvProperty { get; set; }
            public int NumWheels { get; set; }
            public int EngineCylinders { get; set; }
            public int NumSeats { get; set; }
            public int Year { get; set; }
            public string Logo { get; set; }
            public string Headquarters { get; set; }
            public string MakeDescription()
            {
                string description = $"This SUV has a cargo size size of {CargoSize} cu.ft. and a property of {SuvProperty}.\n";
                description += $"The vehicle was manufactured in {Year} with a {EngineCylinders}-cylinder engine, {NumSeats} seats, and {NumWheels} wheels\n";
                description += $"The manufacturer has headquarters in {Headquarters} and uses the logo \"{Logo}\".\n";

                return description;

            }
        }

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var corvette = new Car()
            {
                CarProperty = "fastback",
                EngineCylinders = 8,
                Headquarters = "Detroit, MI",
                Logo = "Corvette Logo.jpg",
                NumSeats = 2,
                NumWheels = 4,
                TrunkSize = 36,
                Year = 2018
            };
            var f150 = new Truck()
            {
                BedSize = 144,
                EngineCylinders = 8,
                Headquarters = "Dearborn, MI",
                Logo = "Ford-Tough Logo.png",
                NumSeats = 2,
                NumWheels = 4,
                TruckProperty = "1/2-Ton",
                Year = 2015
            };
            var acadia = new Suv()
            {
                CargoSize = 50,
                EngineCylinders = 6,
                Headquarters = "Detroit, MI",
                Logo = "GMC Logo.jpg",
                NumSeats = 8,
                NumWheels = 4,
                SuvProperty = "All-seat video",
                Year = 2020
            };

            Console.WriteLine(corvette.MakeDescription() + "--------------");
            Console.WriteLine(f150.MakeDescription() + "--------------");
            Console.WriteLine(acadia.MakeDescription() + "--------------");
        }

    }
}
