using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassVehicle;

namespace OOP.ConsoleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the vehicle");

                string vehicleType = Console.ReadLine().ToLower();

                Sounds soundVehicle = null;

                switch (vehicleType)
                {
                    case "car":
                        soundVehicle = new Car();
                        break;

                    case "train":
                        soundVehicle = new Train();
                        break;

                    case "truck":
                        soundVehicle = new Truck();
                        break;

                    default:
                        Console.WriteLine("text vehicle not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (soundVehicle != null)
                {
                    soundVehicle.vehicleSounds();
                }
            }
        }
    }
}
