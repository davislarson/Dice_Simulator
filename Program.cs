// See https://aka.ms/new-console-template for more information

using static System.Console;
using DiceMission2;

internal class Program
{
    public static void Main(string[] args)
    {
        int rolls = 0;

        // Bring in the class to roll the dice
        RollDice rd = new RollDice();
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        rolls = int.Parse(ReadLine());
        
        
        Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls " + rolls);

        Dictionary<int,int> numbers = rd.Roll(rolls);
        
        
        
        for (int i = 2; i < 13; i++)
        {
            Console.Write(i + ": ");
            for (int j = 1; j < numbers[i] ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye!");
    }
}