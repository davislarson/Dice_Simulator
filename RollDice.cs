namespace DiceMission2
{
    public class RollDice
    {
        public Dictionary<int, int> Roll(int rolls)
        {
            // Allow for use of random numbers
            Random random = new Random();

            // Use an empty dictionary to store the counts of each number rolled
            System.Collections.Generic.Dictionary<int, int> counts = new Dictionary<int, int>
            {
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 },
                { 7, 0 },
                { 8, 0 },
                { 9, 0 },
                { 10, 0 },
                { 11, 0 },
                { 12, 0 }
            };

            for (int i = 0; i < rolls; i++)
            {
                int dice1 = random.Next(1, 7); // Random number between 1 and 6
                int dice2 = random.Next(1, 7);

                int value = dice1 + dice2;
                
                // Increment the value in the dictionary by one each time it is rolled
                counts[value]++;
            }
            
            // Create a list to iterate over the dictionary keys
            List<int> keys = new List<int>(counts.Keys);

            foreach(var key in keys)
            {
                // Must convert to a double and round to avoid truncation
                counts[key] = (int)Math.Round(((double)counts[key] / rolls) * 100);
            }

            return counts;
        }
    }
}