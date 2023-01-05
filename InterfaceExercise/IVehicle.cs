using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        //Properties of the IVehicle interface
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public bool HasChangedGears { get; set; }

        //Stubbed out methods of IVehicle interface
        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
    }
}

