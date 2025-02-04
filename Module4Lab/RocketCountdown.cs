//Author: Somi Seol
//Date: 4 Feb 2025

using System;
using System.Threading;

namespace Module4Lab
{
    class RocketCountdown
    {
        public static void RunRocketProgram()
        {
            Console.WriteLine("Welcome to Rocket Countdown!");
            Console.WriteLine("Get ready for liftoff...\n");

            // First countdown using a for loop
            Console.WriteLine("Starting main engine test...");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"T-{i} seconds...");
                Thread.Sleep(1000); // Pause for one second. Sleep() is in milliseconds
            }
            Console.WriteLine("Main engines tested successfully!\n");

            // Second countdown using a while loop
            Console.WriteLine("Beginning final countdown!");
            int countdown = 10;
            do
            {
                Console.WriteLine($"T-{countdown} seconds...");
                Thread.Sleep(1000); //pause for 1 second
                countdown--;
            }
            while (countdown > 0);
            // Liftoff sequence
            Console.WriteLine("\n🚀 Liftoff! We have liftoff!");
            
            // Altitude reporting using a for loop with a different increment
            for (int altitude = 0; altitude <= 50; altitude += 10)
            {
                Console.WriteLine($"Altitude: {altitude} kilometers");
                Thread.Sleep(500); ///pause for .5 second
            }

            Console.WriteLine("\nMission successful!The rocket has reached its target altitude.");
        }
    }
}