using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public string Logo { get; set; }

        public string CoName { get; set; }

        public bool IsElectric { get; set; }

        public string TrunkSpace { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int WheelCount { get; set; }
    }
}

