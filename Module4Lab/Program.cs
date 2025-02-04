using System;

namespace Module4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //welcome msg
                Console.Clear();
                Console.WriteLine("🚀 Module 4 Lab Menu 🦁");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Launch Rocket Countdown");
                Console.WriteLine("2. Manage Zoo Animals");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        RocketCountdown.RunRocketProgram();
                        break;
                    case "2":
                        Console.Clear();
                        ZooAnimals.RunZooProgram();
                        break;
                    case "3":
                        Console.WriteLine("\nThank you for using the Module 4 Lab programs!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                        break;
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}