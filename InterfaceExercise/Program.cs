using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. - DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company - DONE
             * regardless of vehicle type. - DONE
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class - DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE
            //Creatively display and organize their values - DONE

            //Creating a new instance of the Car class
            var Charger = new Car()
            {
                Make = "Dodge",
                Model = "Charger SXT",
                DoorCount = 4,
                HasChangedGears = true,
                CompanyName = "Earnhardt Dodge",
                Motto = "If you aint first, you're last",
                HasTrunk = true,
                IsCompact = false

            };

            //Creating a new instance of the Truck class
            var Raptor = new Truck()
            {
                NumberOfWheels = 4,
                Make = "Ford",
                Model = "Raptor V8",
                DoorCount = 4,
                HasChangedGears = false,
                CompanyName = "San Tan Ford",
                Motto = "Built Ford Tough",
                HasFourWheelDrive = true,
                HasExtendedCab = true

            };

            //Creating a new instance of the SUV class
            var Telluride = new SUV()
            {
                NumberOfWheels = 4,
                Make = "Kia",
                Model = "Telluride EX",
                DoorCount = 4,
                HasChangedGears = true,
                CompanyName = "Horne Kia",
                Motto = "Movement that inspires",
                HasThirdRow = true,
                CanTow = true

            };

            //Creating list to display the details of each IVehicle
            var vehicles = new List<IVehicle>() { Charger, Raptor, Telluride };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}"); 
                vehicle.Drive();
                vehicle.ChangeGears(vehicle.HasChangedGears);
                vehicle.Reverse();
                Console.WriteLine("");

            }

            Console.WriteLine("------------");

            //Creating list to display the details of each ICompany
            var CompanyInterface = new List<ICompany>() { Charger, Raptor, Telluride };

            foreach (var vehicle in CompanyInterface)
            {
                Console.WriteLine($"{vehicle.CompanyName}'s motto is \"{vehicle.Motto}\".");
                Console.WriteLine("");
            }
        }
    }
}
