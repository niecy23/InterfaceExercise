using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
        //Constructor
        public Car()
		{
        }

        //Implemented properties of the IVehicle Interface
        public int NumberOfWheels { get; set; } = 4;
        public string Make { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public bool HasChangedGears { get; set; }

        //Implemented properties of the ICompany Interface
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        //Properties of the Car class
        public bool HasTrunk { get; set; }
        public bool IsCompact{ get; set; }


        //Implementation of IVehicle interface stubbed out methods
        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name.ToLower()} is now driving forward.");
            if (IsCompact == true && HasTrunk == true)
            {
                Console.WriteLine($"This car is compact, and it has a trunk."); 
            }
            else if (IsCompact == true && HasTrunk == false)
            {
                Console.WriteLine($"This car is compact, but it does not have a trunk.");
            }
            else if (IsCompact == false && HasTrunk == true)
            {
                Console.WriteLine($"This car is not compact, but it does have a trunk");
            }
            else
            {
                Console.WriteLine($"This car is not compact, and it does not have a trunk");
            }

        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"This {GetType().Name.ToLower()} is now going in reverse.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("It cannot reverse until you change gears.");
            }
            
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"This {GetType().Name.ToLower()} is now parked.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("It cannot park until you change gears.");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

