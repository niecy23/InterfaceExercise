using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        //Constructor
        public SUV()
        {
        }

        //Implemented properties of the IVehicle Interface
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public bool HasChangedGears { get; set; }

        //Implemented properties of the ICompany Interface
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        //Properties of the SUV class
        public bool HasThirdRow { get; set; }
        public bool CanTow { get; set; }


        //Implementation of IVehicle interface stubbed out methods
        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is climbing forward.");
            if (HasThirdRow == true && CanTow == true)
            {
                Console.WriteLine($"The passengers can stretch out in the third row while you tow a trailer if needed.");
            }
            else if (HasThirdRow == true && CanTow == false)
            {
                Console.WriteLine($"The passengers can stretch out in the third row, but towing is off limits.");
            }
            else if (HasThirdRow == false && CanTow == true)
            {
                Console.WriteLine($"There is no third row, but it can still tow.");
            }
            else
            {
                Console.WriteLine($"It might as well be a car.");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"This {GetType().Name} is now going in reverse.");
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
                Console.WriteLine($"This {GetType().Name} is now parked.");
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

