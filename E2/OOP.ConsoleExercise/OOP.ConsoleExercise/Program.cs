using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Type the vehicle");

                string vehicleType = Console.ReadLine().ToLower();

                Vehicle soundVehicle = null;

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
