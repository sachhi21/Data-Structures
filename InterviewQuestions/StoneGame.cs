using System;

namespace Data_Structures.InterviewQuestions
{
    public class StoneGame
    {
        public static bool StoneGameWin(int[] piles)
        {
            int totalPiles = piles.Length;

            // Create a DP table to memorize the game's outcomes at different states.
            int[,] dp = new int[totalPiles, totalPiles];

            // Base case: When there's only one pile, the best score is the number of stones in it.
            for (int i = 0; i < totalPiles; ++i)
            {
                dp[i, i] = piles[i];
            }

            // Fill in the DP table, starting from the second last row, moving upwards.
            // This way we handle all subarrays of increasing lengths.
            for (int startIndex = totalPiles - 2; startIndex >= 0; --startIndex)
            {
                for (int endIndex = startIndex + 1; endIndex < totalPiles; ++endIndex)
                {
                    // The current player can choose either the starting or ending pile,
                    // and the score is the max of these two choices minus the score of 
                    // the next player's best choice.
                    int pickStartPile = piles[startIndex] - dp[startIndex + 1, endIndex];
                    int pickEndPile = piles[endIndex] - dp[startIndex, endIndex - 1];
                    dp[startIndex, endIndex] = Math.Max(pickStartPile, pickEndPile);
                }
            }

            // If the score accumulated from the first pile to the last pile is positive,
            // then the first player (Alice) wins.
            return dp[0, totalPiles - 1] > 0;
        }

        // Example usage
       
    }
}
