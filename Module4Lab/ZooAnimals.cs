using System;

namespace Module4Lab
{
    class ZooAnimals
    {
        public static void RunZooProgram()
        {
            // welcome msg
            Console.WriteLine("Welcome to the Zoo Animals Program!");
            Console.WriteLine("Let's create a list of animals in our zoo.\n");

            // Get the number of animals
            Console.Write("How many animals would you like to add? ");
            int numberOfAnimals;
            while (!int.TryParse(Console.ReadLine(), out numberOfAnimals) || numberOfAnimals <= 0) // invert bool from TryParse(), assigns to numberOfAnimals if true and breaks loop; loops if false or if user input is negative
            {
                Console.Write("Please enter a valid number greater than 0: ");
            }

            // Create an array to store animal names
            string[] animals = new string[numberOfAnimals];

            // Get animal names from user
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.Write($"\nEnter name for animal #{i + 1}: ");
                string animalName = Console.ReadLine();
                
                // Make sure they entered something
                while (string.IsNullOrWhiteSpace(animalName))
                {
                    Console.Write("Name cannot be empty. Please enter a name: ");
                    animalName = Console.ReadLine();
                }
                
                animals[i] = animalName;
            }

            // Display all animals
            Console.WriteLine("\nHere are all the animals in your zoo:");
            Console.WriteLine("------------------------------------");
            
            int count = 1;
            foreach (string animal in animals)
            {
                Console.WriteLine($"{count}. {animal}");
                count++;
            }
            
            Console.WriteLine("\nThank you for using the Zoo Animals Program!");
        } 
     }
}
