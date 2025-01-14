// See https://aka.ms/new-console-template for more information

using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        int rolls = 0;
        int[] numbers = new int[10];

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        rolls = int.Parse(ReadLine());
        
        
        Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls " + rolls);

        for (int i = 2; i < 13; i++)
        {
            Console.WriteLine(i + ": ---");
        }
        
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye!");
        
        

    }
}