namespace DiceMission2
{
    public class RollDice
    {
        public int[] Roll(int rolls)
        {
            // Allow for use of random numbers
            Random random = new Random();

            // Use an empty dictionary to store the counts of each number rolled
            int[] counts = new int[11];

            for (int i = 0; i < rolls; i++)
            {
                int dice1 = random.Next(1, 7); // Random number between 1 and 6
                int dice2 = random.Next(1, 7);

                int value = dice1 + dice2;
                
                // Increment the value in the dictionary by one each time it is rolled
                counts[(value-2)]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                // Must convert to a double and round to avoid truncation
                counts[i] = (int)Math.Round(((double)counts[i] / rolls) * 100);
            }

            return counts;
        }
    }
}