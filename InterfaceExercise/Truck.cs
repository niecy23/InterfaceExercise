using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        //Constructor
        public Truck()
		{
        }

        //Implemented properties of the IVehicle Interface
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public bool HasChangedGears { get; set; }

        //Implemented properties of the ICompany Interface
        public string CompanyName { get ; set; }
        public string Motto { get; set; }

        //Properties of the Truck class
        public bool HasFourWheelDrive { get; set; }
        public bool HasExtendedCab { get; set; }


        //Implementation of IVehicle interface stubbed out methods
        public void Drive()
        {
            if (HasFourWheelDrive == true && HasExtendedCab == true)
            {
                Console.WriteLine($"This extended cab, 4 wheel drive {GetType().Name.ToLower()} is now driving forward.");
            }
            else if (HasFourWheelDrive == true && HasExtendedCab == false)
            {
                Console.WriteLine($"This 4 wheel drive {GetType().Name.ToLower()} is now driving forward.");
            }
            else if (HasFourWheelDrive == false && HasExtendedCab == true)
            {
                Console.WriteLine($"This extended cab {GetType().Name.ToLower()} is now driving forward.");
            }
            else
            {
                Console.WriteLine($"This {GetType().Name.ToLower()} is now driving forward.");
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

