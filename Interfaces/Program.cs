using Exercise.Models;
using Exersice.Models.Interfaces;
using Interfaces;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            AirTransport jet = new();
            jet.MaximumCapacity = 5;
            jet.MaximumSpeed = 900;
            jet.MaximumHeight = 20;
            jet.Land();
            jet.Fly();

            LandTransport tank = new();
            tank.MaximumCapacity = 5;
            tank.MaximumSpeed = 60;
            tank.NumberOfWheels = 2;
            tank.HandleOnLand();

            WaterTransport canoe = new();
            canoe.MaximumCapacity = 2;
            canoe.MaximumSpeed = 20;
            canoe.Navigate();

            Toyota corolla = new();

            ElectricFlyingCar strangeCar = new();

            Boat boat = new();
        }
    }

}
