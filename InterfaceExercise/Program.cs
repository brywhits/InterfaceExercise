using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
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

            var subaru = new Car();
            subaru.Make = "Subaru";
            subaru.Model = "WRX";
            subaru.WheelCount = 4;
            subaru.Year = 2020;
            subaru.CoName = "Subaru";
            subaru.IsElectric = false;

            var gmc = new Truck();
            gmc.Make = "GMC";
            gmc.Model = "Sierra";
            gmc.Year = 2023;
            gmc.WheelCount = 4;
            gmc.BedLength = "6ft";
            gmc.CoName = "GMC";

            var lamborghini = new SUV();
            lamborghini.Model = "Urus";
            lamborghini.Make = "lamborghini";
            lamborghini.Year = 2023;
            lamborghini.WheelCount = 4;
            lamborghini.IsHatch = true;

            var parkingLot = new List<IVehicle>() { subaru, gmc, lamborghini };

            foreach (var vehicle in parkingLot)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:" +
                                    $"{vehicle.Year}\nIs Electric: {subaru.IsElectric}\n");
                }

                else if (vehicle is Truck)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:" +
                                    $"{vehicle.Year}\nBedLength: {gmc.BedLength}\n");
                }

                else 
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:" +
                                    $"{vehicle.Year}\nIs Hatchback: {lamborghini.IsHatch}");
                }

            }


        }
    }
}
