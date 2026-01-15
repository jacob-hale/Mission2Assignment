using System;
using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int NumRolls;
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        NumRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("===========================================");
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + NumRolls);
        Console.WriteLine("===========================================");

        // run the DiceRoll constructor and save to value
        DiceRoll diceSimulator = new DiceRoll(NumRolls);

        // run the roll method from that instance with the NumRolls
        int[] results = diceSimulator.Roll();

        // iterate through the array it returns and output the count of combinations
        for (int i = 0; i < results.Length; i++)
        {
            // floor division to find i's count's percentage of total
            int starCount = (int)Math.Round(((double)results[i] / NumRolls) * 100, MidpointRounding.AwayFromZero);
            string stars = new string('*', starCount);
            Console.WriteLine(i + 2 + ": " + stars);
        }

        Console.WriteLine("===========================================");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}